using System;
using TrackableClassLibrary.Entities.Service.Net45.Models;

namespace RestoreDatabaseHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LicensingContext())
            {
                foreach (var licence in context.Licences)
                {
                    Console.WriteLine(licence.Id);
                }
            }
        }
    }
}
