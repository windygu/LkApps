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
namespace Apps.Service.SCV.WORK
{
	public class Virtual_WORK_ORDER_DETAIL_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.WORK.IWORK_ORDER_DETAIL_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.WORK_ORDER_DETAIL;
			}
		}
		

		public virtual List<Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL> GetList(Expression<Func<Apps.Models.WORK_ORDER_DETAIL, bool>> where = null){
		
				IQueryable<Apps.Models.WORK_ORDER_DETAIL> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.WORK_ORDER_DETAIL, bool>> where,Expression<Func<Apps.Models.WORK_ORDER_DETAIL, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.WORK_ORDER_DETAIL> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.WORK_ORDER_DETAIL, bool>> where = null)
		{

			IQueryable<Apps.Models.WORK_ORDER_DETAIL> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								
								,a=>a.WAREHOUSE.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								
								
								
								
								
								|| a.QUANTITY_UM.Contains(queryStr)
								|| a.FROM_LOC.Contains(queryStr)
								|| a.ALLOCATION_RULE.Contains(queryStr)
								
								|| a.TASK_CREATED.Contains(queryStr)
								|| a.ALLOCATED.Contains(queryStr)
								
								|| a.CONVERTED_UM.Contains(queryStr)
								|| a.ITEM_DESC.Contains(queryStr)
								|| a.IN_ALLOCATION.Contains(queryStr)
								
								|| a.ATTRIBUTE1.Contains(queryStr)
								|| a.ATTRIBUTE2.Contains(queryStr)
								|| a.ATTRIBUTE3.Contains(queryStr)
								|| a.ATTRIBUTE4.Contains(queryStr)
								|| a.ATTRIBUTE5.Contains(queryStr)
								|| a.ATTRIBUTE6.Contains(queryStr)
								|| a.ATTRIBUTE7.Contains(queryStr)
								|| a.ATTRIBUTE8.Contains(queryStr)
								|| a.LPN.Contains(queryStr)
								|| a.PARENT_LPN.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL> CreateModelList(ref IQueryable<Apps.Models.WORK_ORDER_DETAIL> queryData)
		{

			List<Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													INTERNAL_WORK_ORDER_NUM = r.INTERNAL_WORK_ORDER_NUM,
													WAREHOUSE = r.WAREHOUSE,
													ITEM = r.ITEM,
													COMPANY = r.COMPANY,
													BUILD_SEQ = r.BUILD_SEQ,
													BUILD_LEVEL = r.BUILD_LEVEL,
													QTY_NEEDED_PER_ITEM = r.QTY_NEEDED_PER_ITEM,
													TOTAL_QTY_NEEDED = r.TOTAL_QTY_NEEDED,
													TOTAL_QTY_USED = r.TOTAL_QTY_USED,
													QUANTITY_UM = r.QUANTITY_UM,
													FROM_LOC = r.FROM_LOC,
													ALLOCATION_RULE = r.ALLOCATION_RULE,
													INTERNAL_WAVE_NUM = r.INTERNAL_WAVE_NUM,
													TASK_CREATED = r.TASK_CREATED,
													ALLOCATED = r.ALLOCATED,
													TOTAL_CONVERTED_QTY_NEEDED = r.TOTAL_CONVERTED_QTY_NEEDED,
													CONVERTED_UM = r.CONVERTED_UM,
													ITEM_DESC = r.ITEM_DESC,
													IN_ALLOCATION = r.IN_ALLOCATION,
													ATTRIBUTE_NUM = r.ATTRIBUTE_NUM,
													ATTRIBUTE1 = r.ATTRIBUTE1,
													ATTRIBUTE2 = r.ATTRIBUTE2,
													ATTRIBUTE3 = r.ATTRIBUTE3,
													ATTRIBUTE4 = r.ATTRIBUTE4,
													ATTRIBUTE5 = r.ATTRIBUTE5,
													ATTRIBUTE6 = r.ATTRIBUTE6,
													ATTRIBUTE7 = r.ATTRIBUTE7,
													ATTRIBUTE8 = r.ATTRIBUTE8,
													LPN = r.LPN,
													PARENT_LPN = r.PARENT_LPN,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													USER_STAMP = r.USER_STAMP,
													PROCESS_STAMP = r.PROCESS_STAMP,
													CREATED_DATE_TIME = r.CREATED_DATE_TIME,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL model)
		{
				Apps.Models.WORK_ORDER_DETAIL entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.WORK_ORDER_DETAIL();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.INTERNAL_WORK_ORDER_NUM = model.INTERNAL_WORK_ORDER_NUM;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.ITEM = model.ITEM;
				entity.COMPANY = model.COMPANY;
				entity.BUILD_SEQ = model.BUILD_SEQ;
				entity.BUILD_LEVEL = model.BUILD_LEVEL;
				entity.QTY_NEEDED_PER_ITEM = model.QTY_NEEDED_PER_ITEM;
				entity.TOTAL_QTY_NEEDED = model.TOTAL_QTY_NEEDED;
				entity.TOTAL_QTY_USED = model.TOTAL_QTY_USED;
				entity.QUANTITY_UM = model.QUANTITY_UM;
				entity.FROM_LOC = model.FROM_LOC;
				entity.ALLOCATION_RULE = model.ALLOCATION_RULE;
				entity.INTERNAL_WAVE_NUM = model.INTERNAL_WAVE_NUM;
				entity.TASK_CREATED = model.TASK_CREATED;
				entity.ALLOCATED = model.ALLOCATED;
				entity.TOTAL_CONVERTED_QTY_NEEDED = model.TOTAL_CONVERTED_QTY_NEEDED;
				entity.CONVERTED_UM = model.CONVERTED_UM;
				entity.ITEM_DESC = model.ITEM_DESC;
				entity.IN_ALLOCATION = model.IN_ALLOCATION;
				entity.ATTRIBUTE_NUM = model.ATTRIBUTE_NUM;
				entity.ATTRIBUTE1 = model.ATTRIBUTE1;
				entity.ATTRIBUTE2 = model.ATTRIBUTE2;
				entity.ATTRIBUTE3 = model.ATTRIBUTE3;
				entity.ATTRIBUTE4 = model.ATTRIBUTE4;
				entity.ATTRIBUTE5 = model.ATTRIBUTE5;
				entity.ATTRIBUTE6 = model.ATTRIBUTE6;
				entity.ATTRIBUTE7 = model.ATTRIBUTE7;
				entity.ATTRIBUTE8 = model.ATTRIBUTE8;
				entity.LPN = model.LPN;
				entity.PARENT_LPN = model.PARENT_LPN;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.USER_STAMP = model.USER_STAMP;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL model,params string[] updateProperties)
		{
				Apps.Models.WORK_ORDER_DETAIL entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.INTERNAL_WORK_ORDER_NUM = model.INTERNAL_WORK_ORDER_NUM;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.ITEM = model.ITEM;
											entity.COMPANY = model.COMPANY;
											entity.BUILD_SEQ = model.BUILD_SEQ;
											entity.BUILD_LEVEL = model.BUILD_LEVEL;
											entity.QTY_NEEDED_PER_ITEM = model.QTY_NEEDED_PER_ITEM;
											entity.TOTAL_QTY_NEEDED = model.TOTAL_QTY_NEEDED;
											entity.TOTAL_QTY_USED = model.TOTAL_QTY_USED;
											entity.QUANTITY_UM = model.QUANTITY_UM;
											entity.FROM_LOC = model.FROM_LOC;
											entity.ALLOCATION_RULE = model.ALLOCATION_RULE;
											entity.INTERNAL_WAVE_NUM = model.INTERNAL_WAVE_NUM;
											entity.TASK_CREATED = model.TASK_CREATED;
											entity.ALLOCATED = model.ALLOCATED;
											entity.TOTAL_CONVERTED_QTY_NEEDED = model.TOTAL_CONVERTED_QTY_NEEDED;
											entity.CONVERTED_UM = model.CONVERTED_UM;
											entity.ITEM_DESC = model.ITEM_DESC;
											entity.IN_ALLOCATION = model.IN_ALLOCATION;
											entity.ATTRIBUTE_NUM = model.ATTRIBUTE_NUM;
											entity.ATTRIBUTE1 = model.ATTRIBUTE1;
											entity.ATTRIBUTE2 = model.ATTRIBUTE2;
											entity.ATTRIBUTE3 = model.ATTRIBUTE3;
											entity.ATTRIBUTE4 = model.ATTRIBUTE4;
											entity.ATTRIBUTE5 = model.ATTRIBUTE5;
											entity.ATTRIBUTE6 = model.ATTRIBUTE6;
											entity.ATTRIBUTE7 = model.ATTRIBUTE7;
											entity.ATTRIBUTE8 = model.ATTRIBUTE8;
											entity.LPN = model.LPN;
											entity.PARENT_LPN = model.PARENT_LPN;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.USER_STAMP = model.USER_STAMP;
											entity.PROCESS_STAMP = model.PROCESS_STAMP;
											entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
									}else{
					
						Type type = typeof(Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL);
						Type typeE = typeof(Apps.Models.WORK_ORDER_DETAIL);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL GetById(string id)
		{
			Apps.Models.WORK_ORDER_DETAIL entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//WORK_ORDER_DETAIL entity = m_Rep.GetById(id);
				Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL model = new Apps.Models.SCV.WORK.WORK_ORDER_DETAIL_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.INTERNAL_WORK_ORDER_NUM = entity.INTERNAL_WORK_ORDER_NUM;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.ITEM = entity.ITEM;
				model.COMPANY = entity.COMPANY;
				model.BUILD_SEQ = entity.BUILD_SEQ;
				model.BUILD_LEVEL = entity.BUILD_LEVEL;
				model.QTY_NEEDED_PER_ITEM = entity.QTY_NEEDED_PER_ITEM;
				model.TOTAL_QTY_NEEDED = entity.TOTAL_QTY_NEEDED;
				model.TOTAL_QTY_USED = entity.TOTAL_QTY_USED;
				model.QUANTITY_UM = entity.QUANTITY_UM;
				model.FROM_LOC = entity.FROM_LOC;
				model.ALLOCATION_RULE = entity.ALLOCATION_RULE;
				model.INTERNAL_WAVE_NUM = entity.INTERNAL_WAVE_NUM;
				model.TASK_CREATED = entity.TASK_CREATED;
				model.ALLOCATED = entity.ALLOCATED;
				model.TOTAL_CONVERTED_QTY_NEEDED = entity.TOTAL_CONVERTED_QTY_NEEDED;
				model.CONVERTED_UM = entity.CONVERTED_UM;
				model.ITEM_DESC = entity.ITEM_DESC;
				model.IN_ALLOCATION = entity.IN_ALLOCATION;
				model.ATTRIBUTE_NUM = entity.ATTRIBUTE_NUM;
				model.ATTRIBUTE1 = entity.ATTRIBUTE1;
				model.ATTRIBUTE2 = entity.ATTRIBUTE2;
				model.ATTRIBUTE3 = entity.ATTRIBUTE3;
				model.ATTRIBUTE4 = entity.ATTRIBUTE4;
				model.ATTRIBUTE5 = entity.ATTRIBUTE5;
				model.ATTRIBUTE6 = entity.ATTRIBUTE6;
				model.ATTRIBUTE7 = entity.ATTRIBUTE7;
				model.ATTRIBUTE8 = entity.ATTRIBUTE8;
				model.LPN = entity.LPN;
				model.PARENT_LPN = entity.PARENT_LPN;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.USER_STAMP = entity.USER_STAMP;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.CREATED_DATE_TIME = entity.CREATED_DATE_TIME;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
