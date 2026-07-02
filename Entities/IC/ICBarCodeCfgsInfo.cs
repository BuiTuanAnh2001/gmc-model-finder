using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICBarCodeCfgs")]
    public class ICBarCodeCfgsInfo : BaseInfo
    {
        public ICBarCodeCfgsInfo()
        {
        }
        #region Variables
		protected int _iCBarCodeCfgID;
		protected DateTime _aACreatedDate = DateTime.Now;
		protected String _aACreatedUser = String.Empty;
		protected DateTime _aAUpdatedDate = DateTime.Now;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _iCBarCodeCfgType = String.Empty;
		protected int _iCBarCodeCfgWidth;
		protected int _iCBarCodeCfgHeight;
        protected String _iCBarCodeCfgShowText = String.Empty;

		#endregion
		[Key]
        #region Public properties
		public int ICBarCodeCfgID
		{
			get { return _iCBarCodeCfgID; }
			set
			{
				if (value != this._iCBarCodeCfgID)
				{
					_iCBarCodeCfgID = value;
				}
			}
		}
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		public bool AASelected
		{
			get { return _aASelected; }
			set
			{
				if (value != this._aASelected)
				{
					_aASelected = value;
				}
			}
		}
		public String ICBarCodeCfgType
		{
			get { return _iCBarCodeCfgType; }
			set
			{
				if (value != this._iCBarCodeCfgType)
				{
					_iCBarCodeCfgType = value;
				}
			}
		}
		public int ICBarCodeCfgWidth
		{
			get { return _iCBarCodeCfgWidth; }
			set
			{
				if (value != this._iCBarCodeCfgWidth)
				{
					_iCBarCodeCfgWidth = value;
				}
			}
		}
		public int ICBarCodeCfgHeight
		{
			get { return _iCBarCodeCfgHeight; }
			set
			{
				if (value != this._iCBarCodeCfgHeight)
				{
					_iCBarCodeCfgHeight = value;
				}
			}
		}
        public String ICBarCodeCfgShowText
        {
            get { return _iCBarCodeCfgShowText; }
            set
            {
                if (value != this._iCBarCodeCfgShowText)
                {
                    _iCBarCodeCfgShowText = value;
                }
            }
        }
        #endregion
    }
}