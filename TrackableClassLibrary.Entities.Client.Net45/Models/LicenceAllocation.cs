namespace TrackableClassLibrary.Entities.Client.Net45.Models
{
    using System;
    using System.Collections.Generic;
	using TrackableEntities.Client;

    public partial class LicenceAllocation : EntityBase
    {
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

		public int PersonId
		{ 
			get { return _PersonId; }
			set
			{
				if (Equals(value, _PersonId)) return;
				_PersonId = value;
				NotifyPropertyChanged();
			}
		}
		private int _PersonId;

		public int LicenceId
		{ 
			get { return _LicenceId; }
			set
			{
				if (Equals(value, _LicenceId)) return;
				_LicenceId = value;
				NotifyPropertyChanged();
			}
		}
		private int _LicenceId;

		public DateTime StartDate
		{ 
			get { return _StartDate; }
			set
			{
				if (Equals(value, _StartDate)) return;
				_StartDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime _StartDate;

		public DateTime? EndDate
		{ 
			get { return _EndDate; }
			set
			{
				if (Equals(value, _EndDate)) return;
				_EndDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _EndDate;


		public Licence Licence
		{
			get { return _Licence; }
			set
			{
				if (Equals(value, _Licence)) return;
				_Licence = value;
				LicenceChangeTracker = _Licence == null ? null
					: new ChangeTrackingCollection<Licence> { _Licence };
				NotifyPropertyChanged();
			}
		}
		private Licence _Licence;
		private ChangeTrackingCollection<Licence> LicenceChangeTracker { get; set; }


		public Person Person
		{
			get { return _Person; }
			set
			{
				if (Equals(value, _Person)) return;
				_Person = value;
				PersonChangeTracker = _Person == null ? null
					: new ChangeTrackingCollection<Person> { _Person };
				NotifyPropertyChanged();
			}
		}
		private Person _Person;
		private ChangeTrackingCollection<Person> PersonChangeTracker { get; set; }
    }
}
