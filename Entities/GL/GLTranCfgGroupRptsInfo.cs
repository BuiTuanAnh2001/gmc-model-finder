
using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("GLTranCfgGroupRpts")]
    public class GLTranCfgGroupRptsInfo : BaseInfo
    {
        public GLTranCfgGroupRptsInfo()
        {
        }
        #region Variables
        protected int _gLTranCfgGroupRptID;
        protected String _gLTranCfgGroupRptName = String.Empty;
        protected String _gLTranCfgGroupRptFileName = String.Empty;
        protected int _fK_GLTranCfgGroupID;
        protected bool _aASelected = true;

        #endregion
        [Key]
        #region Public properties
        public int GLTranCfgGroupRptID
        {
            get { return _gLTranCfgGroupRptID; }
            set
            {
                if (value != this._gLTranCfgGroupRptID)
                {
                    _gLTranCfgGroupRptID = value;
                }
            }
        }
        public String GLTranCfgGroupRptName
        {
            get { return _gLTranCfgGroupRptName; }
            set
            {
                if (value != this._gLTranCfgGroupRptName)
                {
                    _gLTranCfgGroupRptName = value;
                }
            }
        }
        public String GLTranCfgGroupRptFileName
        {
            get { return _gLTranCfgGroupRptFileName; }
            set
            {
                if (value != this._gLTranCfgGroupRptFileName)
                {
                    _gLTranCfgGroupRptFileName = value;
                }
            }
        }
        public int FK_GLTranCfgGroupID
        {
            get { return _fK_GLTranCfgGroupID; }
            set
            {
                if (value != this._fK_GLTranCfgGroupID)
                {
                    _fK_GLTranCfgGroupID = value;
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

        #endregion
    }
}
