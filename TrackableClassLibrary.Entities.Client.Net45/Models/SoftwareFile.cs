namespace TrackableClassLibrary.Entities.Client.Net45.Models
{
    using System;
    using System.Collections.Generic;
	using TrackableEntities.Client;

    public partial class SoftwareFile : EntityBase
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

		public string FileName
		{ 
			get { return _FileName; }
			set
			{
				if (Equals(value, _FileName)) return;
				_FileName = value;
				NotifyPropertyChanged();
			}
		}
		private string _FileName;

		public int FileType
		{ 
			get { return _FileType; }
			set
			{
				if (Equals(value, _FileType)) return;
				_FileType = value;
				NotifyPropertyChanged();
			}
		}
		private int _FileType;

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
