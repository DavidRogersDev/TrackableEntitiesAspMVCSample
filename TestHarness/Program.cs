using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TrackableClassLibrary.Entities.Client.Net45.Models;
using TrackableEntities;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            const string serviceBaseAddress = "http://localhost:" + "8510" + "/";
            var client = new HttpClient { BaseAddress = new Uri(serviceBaseAddress) };

            // Get license
            Console.WriteLine("Licence Id {Enter 1} :");
            int licenseId = int.Parse(Console.ReadLine());

            string initialRequest = "Edit/GetLicenceById/" + licenseId;
            var initialContent = new ObjectContent<Licence>(null, new JsonMediaTypeFormatter());
            var initialResponse = client.PostAsync(new Uri(initialRequest, UriKind.Relative), initialContent).Result;
            initialResponse.EnsureSuccessStatusCode();
            Licence license = GetLicenseFromResponse(initialResponse);
            Console.WriteLine("Initial LicenceKey: {0}", license.LicenceKey);

            // Update License
            Console.WriteLine("Update License Key {Enter random characters}:");
            license.LicenceKey = Console.ReadLine();
            license.TrackingState = TrackingState.Modified;
            license.ModifiedProperties = new List<string> {"LicenceKey"};

            string updateRequest = "Edit/EditLicence/";
            var updatedContent = new ObjectContent<Licence>(license, new JsonMediaTypeFormatter());
            var updatedResponse = client.PostAsync(new Uri(updateRequest, UriKind.Relative), updatedContent).Result;
            updatedResponse.EnsureSuccessStatusCode();
            Licence updatedLicense = GetLicenseFromResponse(updatedResponse);
            Console.WriteLine("Updated LicenceKey: {0}", updatedLicense.LicenceKey);

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        private static Licence GetLicenseFromResponse(HttpResponseMessage response)
        {
            var json = response.Content.ReadAsStringAsync().Result;
            var license = JsonConvert.DeserializeObject<Licence>
                (JObject.Parse(json)["licence"].ToString());
            return license;
        }

        // Commenting out main, so that it can be refactored to invoke web api
        /*
        static void Main(string[] args)
        {
            var licensingContext = new LicensingContext();

            var licences = licensingContext.Licences.Include(l => l.LicenceAllocations.Select(la => la.Person));
            var licenceAllocations = licensingContext.LicenceAllocations.Include(la => la.Person);
            
            foreach (var obj in licences)
            {
                var changeTracker = new ChangeTrackingCollection<Licence>(obj);

                obj.LicenceKey = obj.LicenceKey + "bla";

                var hhh = changeTracker.GetChanges();

                Console.WriteLine(obj.Id);
                if (obj.LicenceAllocations.Any())
                    obj.LicenceAllocations.Select(la => la.Person).Select(p => p.LastName).ToList().ForEach(Console.WriteLine);

                Console.WriteLine();
            }

            Console.ReadLine();

            var oi = licences.Join(licenceAllocations, l => l.Id, la => la.LicenceId,
                (l, la) => new
                {
                    licId = l.Id,
                    licAll = la.Person.LastName
                });

            foreach (var obj in oi)
            {
                Console.WriteLine(obj.licId);
                Console.WriteLine(obj.licAll);
                Console.WriteLine();
            }

            //var list = Enumerable.Range(1, 10);

            //var query = PredicateBuilder.False<Licence>();

            //foreach (var i in list)
            //{
            //    int i1 = i;
            //    query = query.Or(p => p.Id == i1);

            //}

            //foreach (var i in licensingContext.Licences.AsExpandable().Where(query))
            //{
            //    Console.WriteLine(i.LicenceKey);
            //}

            //Console.WriteLine("\n");

            //foreach (var i in licensingContext.Licences)
            //{
            //    Console.WriteLine(i.LicenceKey);
            //}

            Console.ReadLine();
        }
        */
    }
}
