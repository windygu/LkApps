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
using System.Linq.Expressions;
namespace Apps.Service.Sys
{
	public class Virtual_SysExceptionService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Sys.ISysExceptionRepository m_Rep{
			 get
			{
				return DBSession.SysException;
			}
		}
		

		public virtual List<Apps.Models.Sys.SysExceptionModel> GetList(Expression<Func<Apps.Models.SysException, bool>> where = null){
		
				IQueryable<SysException> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysExceptionModel> GetListSort<TKey>(Expression<Func<Apps.Models.SysException, bool>> where,Expression<Func<Apps.Models.SysException, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<SysException> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysExceptionModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SysException, bool>> where = null)
		{

			IQueryable<SysException> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.HelpLink.Contains(queryStr)
								|| a.Message.Contains(queryStr)
								|| a.Source.Contains(queryStr)
								|| a.StackTrace.Contains(queryStr)
								|| a.TargetSite.Contains(queryStr)
								|| a.Data.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.Sys.SysExceptionModel> CreateModelList(ref IQueryable<SysException> queryData)
		{

			List<Apps.Models.Sys.SysExceptionModel> modelList = (from r in queryData
											  select new Apps.Models.Sys.SysExceptionModel
											  {
													Id = r.Id,
													HelpLink = r.HelpLink,
													Message = r.Message,
													Source = r.Source,
													StackTrace = r.StackTrace,
													TargetSite = r.TargetSite,
													Data = r.Data,
													CreateTime = r.CreateTime,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Sys.SysExceptionModel model)
		{
				SysException entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new SysException();
			   				entity.Id = model.Id;
				entity.HelpLink = model.HelpLink;
				entity.Message = model.Message;
				entity.Source = model.Source;
				entity.StackTrace = model.StackTrace;
				entity.TargetSite = model.TargetSite;
				entity.Data = model.Data;
				entity.CreateTime = model.CreateTime;
  
				m_Rep.Create(entity);
		}



		 public virtual void RemoveById(ref ValidationErrors errors, string id)
		{
			
				m_Rep.RemoveById(id);
			
		}

		public virtual void RemoveByIds(ref ValidationErrors errors, string[] deleteCollection)
		{
				if (deleteCollection != null)
				{
				   //事务批量删除
				   // using (TransactionScope transactionScope = new TransactionScope())
				   // {
				   //     if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
				   //     {
				   //         transactionScope.Complete();
				   //         return true;
				   //     }
				   //    else
				   //     {
				   //         Transaction.Current.Rollback();
				   //         return false;
				   //     }
				   // }
				   m_Rep.RemoveById(deleteCollection);
				}
		}

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Sys.SysExceptionModel model,params string[] updateProperties)
		{
				SysException entity = m_Rep.GetById(model.Id);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							if (updateProperties.Count() <= 0){
										entity.Id = model.Id;
											entity.HelpLink = model.HelpLink;
											entity.Message = model.Message;
											entity.Source = model.Source;
											entity.StackTrace = model.StackTrace;
											entity.TargetSite = model.TargetSite;
											entity.Data = model.Data;
											entity.CreateTime = model.CreateTime;
									}else{
					
						Type type = typeof(Apps.Models.Sys.SysExceptionModel);
						Type typeE = typeof(Apps.Models.SysException);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Sys.SysExceptionModel GetById(string id)
		{
			SysException entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SysException entity = m_Rep.GetById(id);
				Apps.Models.Sys.SysExceptionModel model = new Apps.Models.Sys.SysExceptionModel();
							  				model.Id = entity.Id;
				model.HelpLink = entity.HelpLink;
				model.Message = entity.Message;
				model.Source = entity.Source;
				model.StackTrace = entity.StackTrace;
				model.TargetSite = entity.TargetSite;
				model.Data = entity.Data;
				model.CreateTime = entity.CreateTime;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
