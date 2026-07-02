using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.GE
{
    [Table("GEDocAuths")]
    public class GEDocAuthsInfo:BaseInfo
    {
 
		#region Variables
		protected int _gEDocAuthID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected int _fK_ADUserID;
		protected int _fK_ADUserGroupID;
		protected int _fK_STModuleID;
		protected int _fK_STModuleDescriptionID;
		protected bool _gEDocAuthCanView = true;
		protected bool _gEDocAuthCanNew = true;
		protected bool _gEDocAuthCanChange = true;
		protected bool _gEDocAuthCanDelete = true;
		protected bool _gEDocAuthCanPost = true;
		protected bool _gEDocAuthCanCancelDoc = true;
		protected bool _gEDocAuthCanUnPost = true;

		#endregion
		[Key]
		#region Public properties
		public int GEDocAuthID
		{
			get { return _gEDocAuthID; }
			set
			{
				if (value != this._gEDocAuthID)
				{
					_gEDocAuthID = value;
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get { return _aACreatedDate; }
			set
			{
				if (value != this._aACreatedDate)
				{
					_aACreatedDate = value;
				}
			}
		}
		public String AACreatedUser
		{
			get { return _aACreatedUser; }
			set
			{
				if (value != this._aACreatedUser)
				{
					_aACreatedUser = value;
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get { return _aAUpdatedDate; }
			set
			{
				if (value != this._aAUpdatedDate)
				{
					_aAUpdatedDate = value;
				}
			}
		}
		public String AAUpdatedUser
		{
			get { return _aAUpdatedUser; }
			set
			{
				if (value != this._aAUpdatedUser)
				{
					_aAUpdatedUser = value;
				}
			}
		}
		public String AAStatus
		{
			get { return _aAStatus; }
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus = value;
				}
			}
		}
		public int FK_ADUserID
		{
			get { return _fK_ADUserID; }
			set
			{
				if (value != this._fK_ADUserID)
				{
					_fK_ADUserID = value;
				}
			}
		}
		public int FK_ADUserGroupID
		{
			get { return _fK_ADUserGroupID; }
			set
			{
				if (value != this._fK_ADUserGroupID)
				{
					_fK_ADUserGroupID = value;
				}
			}
		}
		public int FK_STModuleID
		{
			get { return _fK_STModuleID; }
			set
			{
				if (value != this._fK_STModuleID)
				{
					_fK_STModuleID = value;
				}
			}
		}
		public int FK_STModuleDescriptionID
		{
			get { return _fK_STModuleDescriptionID; }
			set
			{
				if (value != this._fK_STModuleDescriptionID)
				{
					_fK_STModuleDescriptionID = value;
				}
			}
		}
		public bool GEDocAuthCanView
		{
			get { return _gEDocAuthCanView; }
			set
			{
				if (value != this._gEDocAuthCanView)
				{
					_gEDocAuthCanView = value;
				}
			}
		}
		public bool GEDocAuthCanNew
		{
			get { return _gEDocAuthCanNew; }
			set
			{
				if (value != this._gEDocAuthCanNew)
				{
					_gEDocAuthCanNew = value;
				}
			}
		}
		public bool GEDocAuthCanChange
		{
			get { return _gEDocAuthCanChange; }
			set
			{
				if (value != this._gEDocAuthCanChange)
				{
					_gEDocAuthCanChange = value;
				}
			}
		}
		public bool GEDocAuthCanDelete
		{
			get { return _gEDocAuthCanDelete; }
			set
			{
				if (value != this._gEDocAuthCanDelete)
				{
					_gEDocAuthCanDelete = value;
				}
			}
		}
		public bool GEDocAuthCanPost
		{
			get { return _gEDocAuthCanPost; }
			set
			{
				if (value != this._gEDocAuthCanPost)
				{
					_gEDocAuthCanPost = value;
				}
			}
		}
		public bool GEDocAuthCanCancelDoc
		{
			get { return _gEDocAuthCanCancelDoc; }
			set
			{
				if (value != this._gEDocAuthCanCancelDoc)
				{
					_gEDocAuthCanCancelDoc = value;
				}
			}
		}
		public bool GEDocAuthCanUnPost
		{
			get { return _gEDocAuthCanUnPost; }
			set
			{
				if (value != this._gEDocAuthCanUnPost)
				{
					_gEDocAuthCanUnPost = value;
				}
			}
		}

		#endregion
	}
}
