//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Microsoft.Practices.Unity;
using System.Transactions;
using Apps.Locale;
using Apps.Models.Sys;

namespace Apps.Service.Sys
{
    public partial class SysRightService : Virtual_SysRightService, Apps.IService.Sys.ISysRightService
    {
        //public List<RoleModuleModel> GetRightByRoleAndModule(string roleId, string moduleParentId)
        //{
        //    List<SysModule> queryData = DBSession.SysModule.GetList(a => a.ParentId == moduleParentId && a.Enable == true).OrderBy(a => a.Sort).ToList();

        //    //List<SysModule> tempList = new List<SysModule>();
        //    //foreach (var item in queryData)
        //    //{
        //    //    if (item.OperationType == 3)
        //    //    {
        //    //        tempList.AddRange(DBSession.SysModule.GetList(a => a.ParentId == item.Id && a.Enable == true).OrderBy(a => a.Sort));
        //    //    }
        //    //}

        //    //queryData.AddRange(tempList);
        //    List<Apps.Models.RoleModuleModel> modelList = new List<RoleModuleModel>();
        //    foreach (var item in queryData)
        //    {
        //        RoleModuleModel model = new RoleModuleModel();

        //        model.ModuleId = item.Id;
        //        model.OperationType = item.OperationType;
        //        model.Name = item.Name;
        //        model.IsLast = item.IsLast;
        //        if (DBSession.SysRight.GetList(r => r.RoleId == roleId && r.ModuleId == item.Id).Count() > 0)
        //        {
        //            model.IsValid = true;
        //        }
        //        modelList.Add(model);
        //    }

        //    return modelList;
        //}
        public void UpdateRight(ref ValidationErrors errors, List<SysRightUpdateModel> models)
        {
           

            foreach (var model in models) {
                

                //if (m_Rep.GetById(model.RoleId) == null) {
                //    errors.Add("角色不存在!");
                //    return;
                //}

                //if (DBSession.SysModule.GetById(model.RoleId) == null)
                //{
                //    errors.Add("模块不存在!");
                //    return;
                //}

                //SysRight right = m_Rep.GetList(r => r.RoleId == model.RoleId && r.ModuleId == model.ModuleId).FirstOrDefault();


                if (model.@checked)
                {

                    //if (m_Rep.GetList(r => r.RoleId == model.roleId && r.ModuleId == model.id).Count() > 0)
                    //{
                    //    break;
                    //}
                    AddRoleRight(model.roleId, model.id);
                }
                else
                {
                    IQueryable<SysModule> modules = DBSession.SysModule.GetList(m => m.ParentId == model.id);
                    foreach (var item in modules)
                    {
                        //if (m_Rep.GetList(r => r.RoleId == model.roleId && r.ModuleId == item.Id).Count() > 0)
                        //{
                        //    //errors.Add("有下属关联，请先删除下属！!");
                        //    break;
                        //}
                    }

                    RemoveRoleRight(model.roleId, model.id);
                }
            }

        }

        private void AddRoleRight(string roleId, string moduleId)
        {
            SysRight right = m_Rep.GetList(r => r.RoleId == roleId && r.ModuleId == moduleId).FirstOrDefault();
            if (right==null)
            {
                right = new SysRight()
                {
                    RoleId = roleId,
                    ModuleId = moduleId,
                    Id = ResultHelper.NewId,
                    Rightflag = true
                };
                m_Rep.Create(right);
                DBSession.SaveChanges();
                SysModule module = DBSession.SysModule.GetById(moduleId);
                if (module.ParentId != "000")
                {
                    AddRoleRight(roleId, module.ParentId);
                }
            }
        }

        private void RemoveRoleRight(string roleId, string moduleId)
        {
            SysRight right = m_Rep.GetList(r => r.RoleId == roleId && r.ModuleId == moduleId).FirstOrDefault();
            if (right!=null){
                m_Rep.RemoveById(right.Id);
                DBSession.SaveChanges();
                SysModule curModule = DBSession.SysModule.GetById(moduleId);
                IQueryable<SysModule> modules = DBSession.SysModule.GetList(m => m.ParentId == curModule.ParentId);
                int count = 0;
                foreach (var item in modules) {
                    if (count > 0) break;
                    if (m_Rep.GetList(r => r.RoleId == roleId && r.ModuleId == item.Id).Count()>0) {
                        count++;
                    }
                }

                if (count == 0) {
                    RemoveRoleRight(roleId, curModule.ParentId);
                }
            }
        }

        private void GetChildrenModule(string id,ref List<SysModule> modules) {

            List<SysModule> curModules = DBSession.SysModule.GetList(o => o.ParentId == id).OrderBy(s=>s.Sort).ToList();

            modules.AddRange(curModules);

            foreach (var item in curModules) {

                if (DBSession.SysModule.GetList(o => o.ParentId == item.Id).Count() > 0) {
                    GetChildrenModule(item.Id,ref modules);
                }
              
            }
        }

        public List<TreeNode> GetModuleTreeNodes(string id,string roleId) {
            List<SysModule> modules = new List<SysModule>();
            GetChildrenModule(id,ref modules);

            return FillSonNodes(modules, id, roleId);
        }

        private List<TreeNode> FillSonNodes(List<SysModule> modules, string parentId,string roleId) {
            List<TreeNode> sonNodes = null;
            foreach (var item in modules)
            {
                if (item.ParentId == parentId)
                {
                    if (sonNodes == null) sonNodes = new List<TreeNode>();
                    TreeNode sonNode = item.ToNode();
                    if (DBSession.SysRight.GetList(r => r.RoleId == roleId && r.ModuleId == sonNode.id).Count() > 0)
                    {
                        sonNode.@checked = true;
                    }
                    //else
                    //{
                    //    sonNode.@checked = false;
                    //}
                    sonNodes.Add(sonNode);
                    sonNode.children = FillSonNodes(modules, sonNode.id, roleId);
                }
            }
            return sonNodes;
        }

        public List<SysRightModuleModel> GetModuleList(string id) {
            List<SysModule> queryData = DBSession.SysModule.GetList(a => a.ParentId == id && a.Enable == true).OrderBy(a => a.Sort).ToList();

            return (from r in queryData
             select new Apps.Models.Sys.SysRightModuleModel
             {
                 id = r.Id,
                 text = r.Name,
                 isLast = r.IsLast,
                 operationType = r.OperationType,
             }).ToList();
        }
    }
}
