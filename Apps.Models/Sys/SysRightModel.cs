//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.Sys
{
	public partial class SysRightModel:Virtual_SysRightModel
	{

        

    }
    public partial class SysRightModuleModel
    {
        public string id { get; set; }

        public string text { get; set; }

        public short operationType { get; set; }

        public bool isLast { get; set; }

        public string state
        {
            get
            {
                return isLast ? "open" : "closed";
            }

        }
    }

    public partial class SysRightUpdateModel {
        public string id { get; set; }
        public string roleId { get; set; }
        public bool @checked { get; set; }
    }

    //public class ModuleOperateModel {
    //    public string RoleId { get; set; }
    //    public string ModuleId { get; set; }
    //    public string ModuleParentId { get; set; }

    //    public bool IsValid { get; set; }
    //}


}
