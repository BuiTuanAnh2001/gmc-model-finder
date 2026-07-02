using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPProductionOrdrFGLinkBarcodes")]
    public class PPProductionOrdrFGLinkBarcodesInfo
    {
        #region Variables
        protected int _pPProductionOrdrFGLinkBarcodeID;
        protected int _fK_PPProductionOrdrEstFGID;
        protected int _fK_PPProductionOrdrEstRMID;
        protected int _fK_PPProductionOrdrID;

        #endregion
        [Key]
        #region Public properties
        public int PPProductionOrdrFGLinkBarcodeID
        {
            get { return _pPProductionOrdrFGLinkBarcodeID; }
            set
            {
                if (value != this._pPProductionOrdrFGLinkBarcodeID)
                {
                    _pPProductionOrdrFGLinkBarcodeID = value;
                }
            }
        }
        public int FK_PPProductionOrdrEstFGID
        {
            get { return _fK_PPProductionOrdrEstFGID; }
            set
            {
                if (value != this._fK_PPProductionOrdrEstFGID)
                {
                    _fK_PPProductionOrdrEstFGID = value;
                }
            }
        }
        public int FK_PPProductionOrdrEstRMID
        {
            get { return _fK_PPProductionOrdrEstRMID; }
            set
            {
                if (value != this._fK_PPProductionOrdrEstRMID)
                {
                    _fK_PPProductionOrdrEstRMID = value;
                }
            }
        }
        public int FK_PPProductionOrdrID
        {
            get { return _fK_PPProductionOrdrID; }
            set
            {
                if (value != this._fK_PPProductionOrdrID)
                {
                    _fK_PPProductionOrdrID = value;
                }
            }
        }

        #endregion
    }
}
