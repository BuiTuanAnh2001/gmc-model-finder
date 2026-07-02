
using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("GLTranCfgGroupRptParams")]
    public class GLTranCfgGroupRptParamsInfo : BaseInfo
    {
        public GLTranCfgGroupRptParamsInfo()
        {
        }
        #region Variables
        protected int _gLTranCfgGroupRptParamID;
        protected String _gLTranCfgGroupRptParamName = String.Empty;
        protected String _gLTranCfgGroupRptParamField = String.Empty;
        protected int _fK_GLTranCfgGroupRptID;
        protected bool _gLTranCfgGroupRptParamDisplay = true;
        protected String _gLTranCfgGroupRptParamDesc = String.Empty;
        protected String _gLTranCfgGroupRptParamValue = String.Empty;
        #endregion
        [Key]
        #region Public properties
        public int GLTranCfgGroupRptParamID
        {
            get { return _gLTranCfgGroupRptParamID; }
            set
            {
                if (value != this._gLTranCfgGroupRptParamID)
                {
                    _gLTranCfgGroupRptParamID = value;
                }
            }
        }
        public String GLTranCfgGroupRptParamName
        {
            get { return _gLTranCfgGroupRptParamName; }
            set
            {
                if (value != this._gLTranCfgGroupRptParamName)
                {
                    _gLTranCfgGroupRptParamName = value;
                }
            }
        }
        public String GLTranCfgGroupRptParamField
        {
            get { return _gLTranCfgGroupRptParamField; }
            set
            {
                if (value != this._gLTranCfgGroupRptParamField)
                {
                    _gLTranCfgGroupRptParamField = value;
                   }
            }
        }
        public int FK_GLTranCfgGroupRptID
        {
            get { return _fK_GLTranCfgGroupRptID; }
            set
            {
                if (value != this._fK_GLTranCfgGroupRptID)
                {
                    _fK_GLTranCfgGroupRptID = value;
                }
            }
        }
        public bool GLTranCfgGroupRptParamDisplay
        {
            get { return _gLTranCfgGroupRptParamDisplay; }
            set
            {
                if (value != this._gLTranCfgGroupRptParamDisplay)
                {
                    _gLTranCfgGroupRptParamDisplay = value;
                }
            }
        }
        public String GLTranCfgGroupRptParamDesc
        {
            get { return _gLTranCfgGroupRptParamDesc; }
            set
            {
                if (value != this._gLTranCfgGroupRptParamDesc)
                {
                    _gLTranCfgGroupRptParamDesc = value;
                }
            }
        }
        public String GLTranCfgGroupRptParamValue
        {
            get { return _gLTranCfgGroupRptParamValue; }
            set
            {
                if (value != this._gLTranCfgGroupRptParamValue)
                {
                    _gLTranCfgGroupRptParamValue = value;
                }
            }
        }
        #endregion
    }
}
