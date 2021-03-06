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
namespace Apps.Service.SCV.CYCLE
{
	public class Virtual_CYCLE_COUNT_HEADER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.CYCLE.ICYCLE_COUNT_HEADER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.CYCLE_COUNT_HEADER;
			}
		}
		

		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL> GetList(Expression<Func<Apps.Models.CYCLE_COUNT_HEADER, bool>> where = null){
		
				IQueryable<Apps.Models.CYCLE_COUNT_HEADER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.CYCLE_COUNT_HEADER, bool>> where,Expression<Func<Apps.Models.CYCLE_COUNT_HEADER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.CYCLE_COUNT_HEADER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.CYCLE_COUNT_HEADER, bool>> where = null)
		{

			IQueryable<Apps.Models.CYCLE_COUNT_HEADER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								
								
								,a=>a.MASTER_ID.Contains(queryStr)
								|| a.COUNT_TYPE.Contains(queryStr)
								|| a.CONDITION.Contains(queryStr)
								|| a.COUNT_ATTRIBUTE.Contains(queryStr)
								|| a.REFERENCE_ID.Contains(queryStr)
								|| a.REMARK.Contains(queryStr)
								
								
								|| a.INVENTORY_STSES.Contains(queryStr)
								|| a.ITEMS.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.CREATED_USER.Contains(queryStr)
								
								|| a.RELEASED_USER.Contains(queryStr)
								
								|| a.CLOSED_USER.Contains(queryStr)
								
								|| a.LAST_MODIFIED_USER.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL> CreateModelList(ref IQueryable<Apps.Models.CYCLE_COUNT_HEADER> queryData)
		{

			List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL
											  {
													INTERNAL_CYCLE_COUNT_NUM = r.INTERNAL_CYCLE_COUNT_NUM,
													ORIGINAL_CYCLE_COUNT_NUM = r.ORIGINAL_CYCLE_COUNT_NUM,
													ROUND = r.ROUND,
													MASTER_ID = r.MASTER_ID,
													COUNT_TYPE = r.COUNT_TYPE,
													CONDITION = r.CONDITION,
													COUNT_ATTRIBUTE = r.COUNT_ATTRIBUTE,
													REFERENCE_ID = r.REFERENCE_ID,
													REMARK = r.REMARK,
													TOTAL_LOCS = r.TOTAL_LOCS,
													TOTAL_ITEMS = r.TOTAL_ITEMS,
													INVENTORY_STSES = r.INVENTORY_STSES,
													ITEMS = r.ITEMS,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													CREATED_USER = r.CREATED_USER,
													CREATED_DATE_TIME = r.CREATED_DATE_TIME,
													RELEASED_USER = r.RELEASED_USER,
													RELEASED_DATE_TIME = r.RELEASED_DATE_TIME,
													CLOSED_USER = r.CLOSED_USER,
													CLOSED_DATE_TIME = r.CLOSED_DATE_TIME,
													LAST_MODIFIED_USER = r.LAST_MODIFIED_USER,
													LAST_MODIFIED_DATE_TIME = r.LAST_MODIFIED_DATE_TIME,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL model)
		{
				Apps.Models.CYCLE_COUNT_HEADER entity = m_Rep.GetById(model.INTERNAL_CYCLE_COUNT_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.CYCLE_COUNT_HEADER();
			   				entity.INTERNAL_CYCLE_COUNT_NUM = model.INTERNAL_CYCLE_COUNT_NUM;
				entity.ORIGINAL_CYCLE_COUNT_NUM = model.ORIGINAL_CYCLE_COUNT_NUM;
				entity.ROUND = model.ROUND;
				entity.MASTER_ID = model.MASTER_ID;
				entity.COUNT_TYPE = model.COUNT_TYPE;
				entity.CONDITION = model.CONDITION;
				entity.COUNT_ATTRIBUTE = model.COUNT_ATTRIBUTE;
				entity.REFERENCE_ID = model.REFERENCE_ID;
				entity.REMARK = model.REMARK;
				entity.TOTAL_LOCS = model.TOTAL_LOCS;
				entity.TOTAL_ITEMS = model.TOTAL_ITEMS;
				entity.INVENTORY_STSES = model.INVENTORY_STSES;
				entity.ITEMS = model.ITEMS;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.CREATED_USER = model.CREATED_USER;
				entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
				entity.RELEASED_USER = model.RELEASED_USER;
				entity.RELEASED_DATE_TIME = model.RELEASED_DATE_TIME;
				entity.CLOSED_USER = model.CLOSED_USER;
				entity.CLOSED_DATE_TIME = model.CLOSED_DATE_TIME;
				entity.LAST_MODIFIED_USER = model.LAST_MODIFIED_USER;
				entity.LAST_MODIFIED_DATE_TIME = model.LAST_MODIFIED_DATE_TIME;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.CYCLE_COUNT_HEADER entity = m_Rep.GetById(model.INTERNAL_CYCLE_COUNT_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_CYCLE_COUNT_NUM = model.INTERNAL_CYCLE_COUNT_NUM;
											entity.ORIGINAL_CYCLE_COUNT_NUM = model.ORIGINAL_CYCLE_COUNT_NUM;
											entity.ROUND = model.ROUND;
											entity.MASTER_ID = model.MASTER_ID;
											entity.COUNT_TYPE = model.COUNT_TYPE;
											entity.CONDITION = model.CONDITION;
											entity.COUNT_ATTRIBUTE = model.COUNT_ATTRIBUTE;
											entity.REFERENCE_ID = model.REFERENCE_ID;
											entity.REMARK = model.REMARK;
											entity.TOTAL_LOCS = model.TOTAL_LOCS;
											entity.TOTAL_ITEMS = model.TOTAL_ITEMS;
											entity.INVENTORY_STSES = model.INVENTORY_STSES;
											entity.ITEMS = model.ITEMS;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.CREATED_USER = model.CREATED_USER;
											entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
											entity.RELEASED_USER = model.RELEASED_USER;
											entity.RELEASED_DATE_TIME = model.RELEASED_DATE_TIME;
											entity.CLOSED_USER = model.CLOSED_USER;
											entity.CLOSED_DATE_TIME = model.CLOSED_DATE_TIME;
											entity.LAST_MODIFIED_USER = model.LAST_MODIFIED_USER;
											entity.LAST_MODIFIED_DATE_TIME = model.LAST_MODIFIED_DATE_TIME;
									}else{
					
						Type type = typeof(Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL);
						Type typeE = typeof(Apps.Models.CYCLE_COUNT_HEADER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL GetById(string id)
		{
			Apps.Models.CYCLE_COUNT_HEADER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//CYCLE_COUNT_HEADER entity = m_Rep.GetById(id);
				Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL model = new Apps.Models.SCV.CYCLE.CYCLE_COUNT_HEADER_MODEL();
							  				model.INTERNAL_CYCLE_COUNT_NUM = entity.INTERNAL_CYCLE_COUNT_NUM;
				model.ORIGINAL_CYCLE_COUNT_NUM = entity.ORIGINAL_CYCLE_COUNT_NUM;
				model.ROUND = entity.ROUND;
				model.MASTER_ID = entity.MASTER_ID;
				model.COUNT_TYPE = entity.COUNT_TYPE;
				model.CONDITION = entity.CONDITION;
				model.COUNT_ATTRIBUTE = entity.COUNT_ATTRIBUTE;
				model.REFERENCE_ID = entity.REFERENCE_ID;
				model.REMARK = entity.REMARK;
				model.TOTAL_LOCS = entity.TOTAL_LOCS;
				model.TOTAL_ITEMS = entity.TOTAL_ITEMS;
				model.INVENTORY_STSES = entity.INVENTORY_STSES;
				model.ITEMS = entity.ITEMS;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.CREATED_USER = entity.CREATED_USER;
				model.CREATED_DATE_TIME = entity.CREATED_DATE_TIME;
				model.RELEASED_USER = entity.RELEASED_USER;
				model.RELEASED_DATE_TIME = entity.RELEASED_DATE_TIME;
				model.CLOSED_USER = entity.CLOSED_USER;
				model.CLOSED_DATE_TIME = entity.CLOSED_DATE_TIME;
				model.LAST_MODIFIED_USER = entity.LAST_MODIFIED_USER;
				model.LAST_MODIFIED_DATE_TIME = entity.LAST_MODIFIED_DATE_TIME;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
