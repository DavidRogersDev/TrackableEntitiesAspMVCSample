using System;
using System.Collections.Generic;
using System.Data.Entity;
using TrackableClassLibrary.Entities.Service.Net45.Models;

namespace TrackableClassLibrary.Entities.Service.Net45.Contexts
{
    public class LicensingInitializer: DropCreateDatabaseIfModelChanges<LicensingContext>
    {
        protected override void Seed(LicensingContext context)
        {
            AddPeople(context);
            AddSoftware(context);
            AddLicenses(context);
        }

        private void AddPeople(LicensingContext context)
        {
            context.People.Add(new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            });
            context.People.Add(new Person
            {
                Id = 2,
                FirstName = "Susan",
                LastName = "Jones"
            });
        }

        private void AddSoftware(LicensingContext context)
        {
            context.Softwares.Add(new Software
            {
                Id = 1,
                Name = "Software A",
                TypeId = 1
            });
            context.Softwares.Add(new Software
            {
                Id = 2,
                Name = "Software B",
                TypeId = 1
            });
        }

        private void AddLicenses(LicensingContext context)
        {
            context.Licences.Add(new Licence
            {
                Id = 1,
                LicenceKey = "ABCDE",
                SoftwareId = 1,
                LicenceAllocations = new List<LicenceAllocation>
                {
                    new LicenceAllocation
                    {
                        Id = 1,
                        StartDate = new DateTime(2015, 12, 1),
                        PersonId = 1
                    },
                    new LicenceAllocation
                    {
                        Id = 2,
                        StartDate = new DateTime(2015, 12, 2),
                        PersonId = 2
                    }
                }
            });
            context.Licences.Add(new Licence
            {
                Id = 2,
                LicenceKey = "FGHIJ",
                SoftwareId = 2,
                LicenceAllocations = new List<LicenceAllocation>
                {
                    new LicenceAllocation
                    {
                        Id = 3,
                        StartDate = new DateTime(2015, 12, 3),
                        PersonId = 1
                    },
                    new LicenceAllocation
                    {
                        Id = 4,
                        StartDate = new DateTime(2015, 12, 4),
                        PersonId = 2
                    }
                }
            });
        }
    }
}
