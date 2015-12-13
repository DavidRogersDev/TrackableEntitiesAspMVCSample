namespace TrackableClassLibrary.Entities.Client.Net45.Models
{
    using System;
    using System.Collections.Generic;
	using TrackableEntities.Client;

    public partial class Software : EntityBase
    {
        public Software()
        {
            Licences = new ChangeTrackingCollection<Licence>();
            SoftwareFiles = new ChangeTrackingCollection<SoftwareFile>();
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

		public string Description
		{ 
			get { return _Description; }
			set
			{
				if (Equals(value, _Description)) return;
				_Description = value;
				NotifyPropertyChanged();
			}
		}
		private string _Description;

		public string Name
		{ 
			get { return _Name; }
			set
			{
				if (Equals(value, _Name)) return;
				_Name = value;
				NotifyPropertyChanged();
			}
		}
		private string _Name;

		public int TypeId
		{ 
			get { return _TypeId; }
			set
			{
				if (Equals(value, _TypeId)) return;
				_TypeId = value;
				NotifyPropertyChanged();
			}
		}
		private int _TypeId;

		public int? SoftwareType_Id
		{ 
			get { return _SoftwareType_Id; }
			set
			{
				if (Equals(value, _SoftwareType_Id)) return;
				_SoftwareType_Id = value;
				NotifyPropertyChanged();
			}
		}
		private int? _SoftwareType_Id;

		public ChangeTrackingCollection<Licence> Licences
		{
			get { return _Licences; }
			set
			{
				if (Equals(value, _Licences)) return;
				_Licences = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Licence> _Licences;

		public ChangeTrackingCollection<SoftwareFile> SoftwareFiles
		{
			get { return _SoftwareFiles; }
			set
			{
				if (Equals(value, _SoftwareFiles)) return;
				_SoftwareFiles = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<SoftwareFile> _SoftwareFiles;


		public SoftwareType SoftwareType
		{
			get { return _SoftwareType; }
			set
			{
				if (Equals(value, _SoftwareType)) return;
				_SoftwareType = value;
				SoftwareTypeChangeTracker = _SoftwareType == null ? null
					: new ChangeTrackingCollection<SoftwareType> { _SoftwareType };
				NotifyPropertyChanged();
			}
		}
		private SoftwareType _SoftwareType;
		private ChangeTrackingCollection<SoftwareType> SoftwareTypeChangeTracker { get; set; }
    }
}
