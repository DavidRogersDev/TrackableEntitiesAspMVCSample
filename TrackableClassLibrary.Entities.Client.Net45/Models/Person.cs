namespace TrackableClassLibrary.Entities.Client.Net45.Models
{
    using System;
    using System.Collections.Generic;
	using TrackableEntities.Client;

    public partial class Person : EntityBase
    {
        public Person()
        {
            LicenceAllocations = new ChangeTrackingCollection<LicenceAllocation>();
        }

		public int Id
		{ 
			get { return _Id; }
			set
			{
				if (Equals(value, _Id)) return;
				_Id = value;
				NotifyPropertyChanged();
			}
		}
		private int _Id;

		public string FirstName
		{ 
			get { return _FirstName; }
			set
			{
				if (Equals(value, _FirstName)) return;
				_FirstName = value;
				NotifyPropertyChanged();
			}
		}
		private string _FirstName;

		public string LastName
		{ 
			get { return _LastName; }
			set
			{
				if (Equals(value, _LastName)) return;
				_LastName = value;
				NotifyPropertyChanged();
			}
		}
		private string _LastName;

		public ChangeTrackingCollection<LicenceAllocation> LicenceAllocations
		{
			get { return _LicenceAllocations; }
			set
			{
				if (Equals(value, _LicenceAllocations)) return;
				_LicenceAllocations = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<LicenceAllocation> _LicenceAllocations;
    }
}
