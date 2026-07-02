using gmc_api.Base.dto;
using gmc_api.Base.Helpers;
using gmc_api.DTO.Inventoty;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using gmc_api.Entities;
using gmc_api.DTO.InputModel;

namespace gmc_api.DTO.User
{
    public class UserGroupSectionAppModules
    {
        public int STUserGroupSectionAppModuleID
        { get; set; } = 0;
        public string AAStatus
        { get; set; } = "Alive";
        public int FK_ADUserGroupID
        { get; set; } = 0;
        public int STUserGroupSectionAppModuleSortOrder
        { get; set; } = 0;
        public String STUserGroupSectionAppModuleCode
        { get; set; } = string.Empty;
        public String STUserGroupSectionAppModuleName
        { get; set; } = string.Empty;
        public List<STUserGroupAppModules> ListAppModule
        { get; set; } = new List<STUserGroupAppModules>();
    }
    public class UserGroupSectionAppModule_New
    {
        public int STUserGroupSectionAppModuleID
        { get; set; } = 0;
        public string AAStatus
        { get; set; } = "Alive";
        public int FK_ADUserGroupID
        { get; set; } = 0;
        public int STUserGroupSectionAppModuleSortOrder
        { get; set; } = 0;
        public String STUserGroupSectionAppModuleCode
        { get; set; } = string.Empty;
        public String STUserGroupSectionAppModuleName
        { get; set; } = string.Empty;
        public List<STUserGroupAppModule_New> ListAppModule
        { get; set; } = new List<STUserGroupAppModule_New>();
    }
}
