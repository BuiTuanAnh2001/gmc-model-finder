using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("APSetups")]

    public class APSetupsInfo:BaseInfo
	{
		public APSetupsInfo()
		{
		}
		#region Variables
		protected int _aPSetupID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aPSetupContractHandler=String.Empty;
		protected int _aPSetupContractDueDayCount;
		protected int _fK_APPOGroupID;
		#endregion
		[Key]
		#region Public properties
		public int APSetupID
		{
			get{return _aPSetupID;}
			set
			{
				if (value != this._aPSetupID)
				{
				_aPSetupID=value;
				}
			}
		}
		public DateTime AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
				_aACreatedDate=value;
				}
			}
		}
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
				_aACreatedUser=value;
				}
			}
		}
		public DateTime AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
				_aAUpdatedDate=value;
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
				_aAUpdatedUser=value;
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
				_aAStatus=value;
				}
			}
		}
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				}
			}
		}
		public String APSetupContractHandler
		{
			get{return _aPSetupContractHandler;}
			set
			{
				if (value != this._aPSetupContractHandler)
				{
				_aPSetupContractHandler=value;
				}
			}
		}
		public int APSetupContractDueDayCount
		{
			get{return _aPSetupContractDueDayCount;}
			set
			{
				if (value != this._aPSetupContractDueDayCount)
				{
				_aPSetupContractDueDayCount=value;
				}
			}
		}
		public int FK_APPOGroupID
		{
			get{return _fK_APPOGroupID;}
			set
			{
				if (value != this._fK_APPOGroupID)
				{
				_fK_APPOGroupID=value;
				}
			}
		}
		#endregion
	}
}