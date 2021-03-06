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
namespace Apps.Service.SCV.Sys
{
	public class Virtual_ZONE_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.Sys.IZONE_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.ZONE;
			}
		}
		

		public virtual List<Apps.Models.SCV.Sys.ZONE_MODEL> GetList(Expression<Func<Apps.Models.ZONE, bool>> where = null){
		
				IQueryable<Apps.Models.ZONE> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.Sys.ZONE_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.ZONE, bool>> where,Expression<Func<Apps.Models.ZONE, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.ZONE> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.Sys.ZONE_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.ZONE, bool>> where = null)
		{

			IQueryable<Apps.Models.ZONE> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.ZONE1.Contains(queryStr)
								|| a.DESCRIPTION.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.Sys.ZONE_MODEL> CreateModelList(ref IQueryable<Apps.Models.ZONE> queryData)
		{

			List<Apps.Models.SCV.Sys.ZONE_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.Sys.ZONE_MODEL
											  {
													ZONE1 = r.ZONE1,
													DESCRIPTION = r.DESCRIPTION,
													ACTIVE = r.ACTIVE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.Sys.ZONE_MODEL model)
		{
				Apps.Models.ZONE entity = m_Rep.GetById(model.ZONE1);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.ZONE();
			   				entity.ZONE1 = model.ZONE1;
				entity.DESCRIPTION = model.DESCRIPTION;
				entity.ACTIVE = model.ACTIVE;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.Sys.ZONE_MODEL model,params string[] updateProperties)
		{
				Apps.Models.ZONE entity = m_Rep.GetById(model.ZONE1);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.ZONE1 = model.ZONE1;
											entity.DESCRIPTION = model.DESCRIPTION;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.Sys.ZONE_MODEL);
						Type typeE = typeof(Apps.Models.ZONE);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.Sys.ZONE_MODEL GetById(string id)
		{
			Apps.Models.ZONE entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//ZONE entity = m_Rep.GetById(id);
				Apps.Models.SCV.Sys.ZONE_MODEL model = new Apps.Models.SCV.Sys.ZONE_MODEL();
							  				model.ZONE1 = entity.ZONE1;
				model.DESCRIPTION = entity.DESCRIPTION;
				model.ACTIVE = entity.ACTIVE;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
