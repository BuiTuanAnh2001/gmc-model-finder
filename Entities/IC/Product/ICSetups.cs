using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICSetups")]
    public class ICSetups : BaseInfo
    {
        #region Variables
        protected int _iCSetupID;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _iCSetupNo = String.Empty;
        protected String _iCSetupName = String.Empty;
        protected String _iCSetupDesc = String.Empty;
        protected bool _iCSetupAllowNegativeStockCheck = true;
        protected String _iCSetupCalShipmentPriceTypeCombo = String.Empty;
        protected String _iCSetupTransferTypeCombo = String.Empty;
        protected String _iCSetupValTypeCombo = String.Empty;
        protected String _iCSetupUpdateInvTransferTypeCombo = String.Empty;
        protected String _iCSetupCostingCalcTypeCombo = String.Empty;
        protected int _fK_HRWarehousemanID;
        protected String _hRWarehousemanName = String.Empty;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected String _iCSetupQCTypeCombo = String.Empty;
        protected int _fK_ICBarCodeSetupID;
        protected String _iCSetupBarCodeImageCombo = String.Empty;
        protected bool _iCSetupAllowAllInventoryCheck = false;
        protected String _iCSetupPalleteColCombo = String.Empty;
        protected String _iCSetupNegativeStockLVCombo = String.Empty;

        #endregion
        #region Public properties
        [Key]
        public int ICSetupID
        {
            get { return _iCSetupID; }
            set
            {
                if (value != this._iCSetupID)
                {
                    _iCSetupID = value;
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
        public String ICSetupNo
        {
            get { return _iCSetupNo; }
            set
            {
                if (value != this._iCSetupNo)
                {
                    _iCSetupNo = value;
                }
            }
        }
        public String ICSetupName
        {
            get { return _iCSetupName; }
            set
            {
                if (value != this._iCSetupName)
                {
                    _iCSetupName = value;
                }
            }
        }
        public String ICSetupDesc
        {
            get { return _iCSetupDesc; }
            set
            {
                if (value != this._iCSetupDesc)
                {
                    _iCSetupDesc = value;
                }
            }
        }
        public bool ICSetupAllowNegativeStockCheck
        {
            get { return _iCSetupAllowNegativeStockCheck; }
            set
            {
                if (value != this._iCSetupAllowNegativeStockCheck)
                {
                    _iCSetupAllowNegativeStockCheck = value;
                }
            }
        }
        public String ICSetupCalShipmentPriceTypeCombo
        {
            get { return _iCSetupCalShipmentPriceTypeCombo; }
            set
            {
                if (value != this._iCSetupCalShipmentPriceTypeCombo)
                {
                    _iCSetupCalShipmentPriceTypeCombo = value;
                }
            }
        }
        public String ICSetupTransferTypeCombo
        {
            get { return _iCSetupTransferTypeCombo; }
            set
            {
                if (value != this._iCSetupTransferTypeCombo)
                {
                    _iCSetupTransferTypeCombo = value;
                }
            }
        }
        public String ICSetupValTypeCombo
        {
            get { return _iCSetupValTypeCombo; }
            set
            {
                if (value != this._iCSetupValTypeCombo)
                {
                    _iCSetupValTypeCombo = value;
                }
            }
        }
        public String ICSetupUpdateInvTransferTypeCombo
        {
            get { return _iCSetupUpdateInvTransferTypeCombo; }
            set
            {
                if (value != this._iCSetupUpdateInvTransferTypeCombo)
                {
                    _iCSetupUpdateInvTransferTypeCombo = value;
                }
            }
        }
        public String ICSetupCostingCalcTypeCombo
        {
            get { return _iCSetupCostingCalcTypeCombo; }
            set
            {
                if (value != this._iCSetupCostingCalcTypeCombo)
                {
                    _iCSetupCostingCalcTypeCombo = value;
                }
            }
        }
        public int FK_HRWarehousemanID
        {
            get { return _fK_HRWarehousemanID; }
            set
            {
                if (value != this._fK_HRWarehousemanID)
                {
                    _fK_HRWarehousemanID = value;
                }
            }
        }
        public String HRWarehousemanName
        {
            get { return _hRWarehousemanName; }
            set
            {
                if (value != this._hRWarehousemanName)
                {
                    _hRWarehousemanName = value;
                }
            }
        }
        public int FK_ICWeightUOMID
        {
            get { return _fK_ICWeightUOMID; }
            set
            {
                if (value != this._fK_ICWeightUOMID)
                {
                    _fK_ICWeightUOMID = value;
                }
            }
        }
        public int FK_ICVolumeUOMID
        {
            get { return _fK_ICVolumeUOMID; }
            set
            {
                if (value != this._fK_ICVolumeUOMID)
                {
                    _fK_ICVolumeUOMID = value;
                }
            }
        }
        public String ICSetupQCTypeCombo
        {
            get { return _iCSetupQCTypeCombo; }
            set
            {
                if (value != this._iCSetupQCTypeCombo)
                {
                    _iCSetupQCTypeCombo = value;
                }
            }
        }
        public int FK_ICBarCodeSetupID
        {
            get { return _fK_ICBarCodeSetupID; }
            set
            {
                if (value != this._fK_ICBarCodeSetupID)
                {
                    _fK_ICBarCodeSetupID = value;
                }
            }
        }
        public String ICSetupBarCodeImageCombo
        {
            get { return _iCSetupBarCodeImageCombo; }
            set
            {
                if (value != this._iCSetupBarCodeImageCombo)
                {
                    _iCSetupBarCodeImageCombo = value;
                }
            }
        }
        public bool ICSetupAllowAllInventoryCheck
        {
            get { return _iCSetupAllowAllInventoryCheck; }
            set
            {
                if (value != this._iCSetupAllowAllInventoryCheck)
                {
                    _iCSetupAllowAllInventoryCheck = value;
                }
            }
        }
        public String ICSetupPalleteColCombo
        {
            get { return _iCSetupPalleteColCombo; }
            set
            {
                if (value != this._iCSetupPalleteColCombo)
                {
                    _iCSetupPalleteColCombo = value;
                }
            }
        }
        public String ICSetupNegativeStockLVCombo
        {
            get { return _iCSetupNegativeStockLVCombo; }
            set
            {
                if (value != this._iCSetupNegativeStockLVCombo)
                {
                    _iCSetupNegativeStockLVCombo = value;
                }
            }
        }

        #endregion
    }

}
