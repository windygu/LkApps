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
namespace Apps.Service.SCV.PROCESS
{
	public class Virtual_PROCESS_HISTORY_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.PROCESS.IPROCESS_HISTORY_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.PROCESS_HISTORY;
			}
		}
		

		public virtual List<Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL> GetList(Expression<Func<Apps.Models.PROCESS_HISTORY, bool>> where = null){
		
				IQueryable<Apps.Models.PROCESS_HISTORY> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.PROCESS_HISTORY, bool>> where,Expression<Func<Apps.Models.PROCESS_HISTORY, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.PROCESS_HISTORY> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.PROCESS_HISTORY, bool>> where = null)
		{

			IQueryable<Apps.Models.PROCESS_HISTORY> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.WAREHOUSE.Contains(queryStr)
								|| a.PROCESS_TYPE.Contains(queryStr)
								|| a.CONDITION.Contains(queryStr)
								|| a.IDENTIFIER1.Contains(queryStr)
								|| a.IDENTIFIER2.Contains(queryStr)
								|| a.IDENTIFIER3.Contains(queryStr)
								|| a.IDENTIFIER4.Contains(queryStr)
								|| a.IDENTIFIER5.Contains(queryStr)
								|| a.IDENTIFIER6.Contains(queryStr)
								|| a.IDENTIFIER7.Contains(queryStr)
								|| a.IDENTIFIER8.Contains(queryStr)
								|| a.MESSAGE.Contains(queryStr)
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
		public virtual List<Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL> CreateModelList(ref IQueryable<Apps.Models.PROCESS_HISTORY> queryData)
		{

			List<Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL
											  {
													INTERNAL_ID = r.INTERNAL_ID,
													WAREHOUSE = r.WAREHOUSE,
													PROCESS_TYPE = r.PROCESS_TYPE,
													CONDITION = r.CONDITION,
													IDENTIFIER1 = r.IDENTIFIER1,
													IDENTIFIER2 = r.IDENTIFIER2,
													IDENTIFIER3 = r.IDENTIFIER3,
													IDENTIFIER4 = r.IDENTIFIER4,
													IDENTIFIER5 = r.IDENTIFIER5,
													IDENTIFIER6 = r.IDENTIFIER6,
													IDENTIFIER7 = r.IDENTIFIER7,
													IDENTIFIER8 = r.IDENTIFIER8,
													MESSAGE = r.MESSAGE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL model)
		{
				Apps.Models.PROCESS_HISTORY entity = m_Rep.GetById(model.INTERNAL_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.PROCESS_HISTORY();
			   				entity.INTERNAL_ID = model.INTERNAL_ID;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.PROCESS_TYPE = model.PROCESS_TYPE;
				entity.CONDITION = model.CONDITION;
				entity.IDENTIFIER1 = model.IDENTIFIER1;
				entity.IDENTIFIER2 = model.IDENTIFIER2;
				entity.IDENTIFIER3 = model.IDENTIFIER3;
				entity.IDENTIFIER4 = model.IDENTIFIER4;
				entity.IDENTIFIER5 = model.IDENTIFIER5;
				entity.IDENTIFIER6 = model.IDENTIFIER6;
				entity.IDENTIFIER7 = model.IDENTIFIER7;
				entity.IDENTIFIER8 = model.IDENTIFIER8;
				entity.MESSAGE = model.MESSAGE;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL model,params string[] updateProperties)
		{
				Apps.Models.PROCESS_HISTORY entity = m_Rep.GetById(model.INTERNAL_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_ID = model.INTERNAL_ID;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.PROCESS_TYPE = model.PROCESS_TYPE;
											entity.CONDITION = model.CONDITION;
											entity.IDENTIFIER1 = model.IDENTIFIER1;
											entity.IDENTIFIER2 = model.IDENTIFIER2;
											entity.IDENTIFIER3 = model.IDENTIFIER3;
											entity.IDENTIFIER4 = model.IDENTIFIER4;
											entity.IDENTIFIER5 = model.IDENTIFIER5;
											entity.IDENTIFIER6 = model.IDENTIFIER6;
											entity.IDENTIFIER7 = model.IDENTIFIER7;
											entity.IDENTIFIER8 = model.IDENTIFIER8;
											entity.MESSAGE = model.MESSAGE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL);
						Type typeE = typeof(Apps.Models.PROCESS_HISTORY);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL GetById(string id)
		{
			Apps.Models.PROCESS_HISTORY entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//PROCESS_HISTORY entity = m_Rep.GetById(id);
				Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL model = new Apps.Models.SCV.PROCESS.PROCESS_HISTORY_MODEL();
							  				model.INTERNAL_ID = entity.INTERNAL_ID;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.PROCESS_TYPE = entity.PROCESS_TYPE;
				model.CONDITION = entity.CONDITION;
				model.IDENTIFIER1 = entity.IDENTIFIER1;
				model.IDENTIFIER2 = entity.IDENTIFIER2;
				model.IDENTIFIER3 = entity.IDENTIFIER3;
				model.IDENTIFIER4 = entity.IDENTIFIER4;
				model.IDENTIFIER5 = entity.IDENTIFIER5;
				model.IDENTIFIER6 = entity.IDENTIFIER6;
				model.IDENTIFIER7 = entity.IDENTIFIER7;
				model.IDENTIFIER8 = entity.IDENTIFIER8;
				model.MESSAGE = entity.MESSAGE;
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
