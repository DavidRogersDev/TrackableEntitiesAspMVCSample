namespace TrackableClassLibrary.Entities.Client.Net45.Models
{
    using System;
    using System.Collections.Generic;
	using TrackableEntities.Client;

    public partial class SoftwareType : EntityBase
    {
        public SoftwareType()
        {
            Softwares = new ChangeTrackingCollection<Software>();
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

		public ChangeTrackingCollection<Software> Softwares
		{
			get { return _Softwares; }
			set
			{
				if (Equals(value, _Softwares)) return;
				_Softwares = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Software> _Softwares;
    }
}
