namespace TrackableClassLibrary.Entities.Client.Net45.Models
{
    using TrackableEntities.Client;

    public partial class Licence : EntityBase
    {
        public Licence()
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

		public string LicenceKey
		{ 
			get { return _LicenceKey; }
			set
			{
				if (Equals(value, _LicenceKey)) return;
				_LicenceKey = value;
				NotifyPropertyChanged();
			}
		}
		private string _LicenceKey;

		public int SoftwareId
		{ 
			get { return _SoftwareId; }
			set
			{
				if (Equals(value, _SoftwareId)) return;
				_SoftwareId = value;
				NotifyPropertyChanged();
			}
		}
		private int _SoftwareId;

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


		public Software Software
		{
			get { return _Software; }
			set
			{
				if (Equals(value, _Software)) return;
				_Software = value;
				SoftwareChangeTracker = _Software == null ? null
					: new ChangeTrackingCollection<Software> { _Software };
				NotifyPropertyChanged();
			}
		}
		private Software _Software;
		private ChangeTrackingCollection<Software> SoftwareChangeTracker { get; set; }
    }
}
