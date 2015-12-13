﻿using System;
using TrackableEntities.Client;

namespace TestHarness
{
    class Program
    {
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
    }
}
