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
namespace Apps.Service.SCV.PURCHASE
{
	public class Virtual_PURCHASE_ORDER_HEADER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.PURCHASE.IPURCHASE_ORDER_HEADER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.PURCHASE_ORDER_HEADER;
			}
		}
		

		public virtual List<Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL> GetList(Expression<Func<Apps.Models.PURCHASE_ORDER_HEADER, bool>> where = null){
		
				IQueryable<Apps.Models.PURCHASE_ORDER_HEADER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.PURCHASE_ORDER_HEADER, bool>> where,Expression<Func<Apps.Models.PURCHASE_ORDER_HEADER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.PURCHASE_ORDER_HEADER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.PURCHASE_ORDER_HEADER, bool>> where = null)
		{

			IQueryable<Apps.Models.PURCHASE_ORDER_HEADER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.WAREHOUSE.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.PURCHASE_ORDER_ID.Contains(queryStr)
								|| a.PURCHASE_ORDER_TYPE.Contains(queryStr)
								
								
								
								|| a.ERP_ORDER_ID.Contains(queryStr)
								|| a.SHIP_FROM.Contains(queryStr)
								|| a.SHIP_FROM_ADDRESS1.Contains(queryStr)
								|| a.SHIP_FROM_ADDRESS2.Contains(queryStr)
								|| a.SHIP_FROM_CITY.Contains(queryStr)
								|| a.SHIP_FROM_STATE.Contains(queryStr)
								|| a.SHIP_FROM_COUNTRY.Contains(queryStr)
								|| a.SHIP_FROM_POSTAL_CODE.Contains(queryStr)
								|| a.SHIP_FROM_NAME.Contains(queryStr)
								|| a.SHIP_FROM_ATTENTION_TO.Contains(queryStr)
								|| a.SHIP_FROM_EMAIL_ADDRESS.Contains(queryStr)
								|| a.SHIP_FROM_PHONE_NUM.Contains(queryStr)
								|| a.SHIP_FROM_FAX_NUM.Contains(queryStr)
								
								
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
		public virtual List<Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL> CreateModelList(ref IQueryable<Apps.Models.PURCHASE_ORDER_HEADER> queryData)
		{

			List<Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL
											  {
													INTERNAL_PURCHASE_ORDER_NUM = r.INTERNAL_PURCHASE_ORDER_NUM,
													WAREHOUSE = r.WAREHOUSE,
													COMPANY = r.COMPANY,
													PURCHASE_ORDER_ID = r.PURCHASE_ORDER_ID,
													PURCHASE_ORDER_TYPE = r.PURCHASE_ORDER_TYPE,
													CLOSE_DATE = r.CLOSE_DATE,
													PRIORITY = r.PRIORITY,
													STATUS = r.STATUS,
													ERP_ORDER_ID = r.ERP_ORDER_ID,
													SHIP_FROM = r.SHIP_FROM,
													SHIP_FROM_ADDRESS1 = r.SHIP_FROM_ADDRESS1,
													SHIP_FROM_ADDRESS2 = r.SHIP_FROM_ADDRESS2,
													SHIP_FROM_CITY = r.SHIP_FROM_CITY,
													SHIP_FROM_STATE = r.SHIP_FROM_STATE,
													SHIP_FROM_COUNTRY = r.SHIP_FROM_COUNTRY,
													SHIP_FROM_POSTAL_CODE = r.SHIP_FROM_POSTAL_CODE,
													SHIP_FROM_NAME = r.SHIP_FROM_NAME,
													SHIP_FROM_ATTENTION_TO = r.SHIP_FROM_ATTENTION_TO,
													SHIP_FROM_EMAIL_ADDRESS = r.SHIP_FROM_EMAIL_ADDRESS,
													SHIP_FROM_PHONE_NUM = r.SHIP_FROM_PHONE_NUM,
													SHIP_FROM_FAX_NUM = r.SHIP_FROM_FAX_NUM,
													SCHEDULED_ARRIVE_DATE = r.SCHEDULED_ARRIVE_DATE,
													ACTUAL_ARRIVE_DATE = r.ACTUAL_ARRIVE_DATE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL model)
		{
				Apps.Models.PURCHASE_ORDER_HEADER entity = m_Rep.GetById(model.INTERNAL_PURCHASE_ORDER_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.PURCHASE_ORDER_HEADER();
			   				entity.INTERNAL_PURCHASE_ORDER_NUM = model.INTERNAL_PURCHASE_ORDER_NUM;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.COMPANY = model.COMPANY;
				entity.PURCHASE_ORDER_ID = model.PURCHASE_ORDER_ID;
				entity.PURCHASE_ORDER_TYPE = model.PURCHASE_ORDER_TYPE;
				entity.CLOSE_DATE = model.CLOSE_DATE;
				entity.PRIORITY = model.PRIORITY;
				entity.STATUS = model.STATUS;
				entity.ERP_ORDER_ID = model.ERP_ORDER_ID;
				entity.SHIP_FROM = model.SHIP_FROM;
				entity.SHIP_FROM_ADDRESS1 = model.SHIP_FROM_ADDRESS1;
				entity.SHIP_FROM_ADDRESS2 = model.SHIP_FROM_ADDRESS2;
				entity.SHIP_FROM_CITY = model.SHIP_FROM_CITY;
				entity.SHIP_FROM_STATE = model.SHIP_FROM_STATE;
				entity.SHIP_FROM_COUNTRY = model.SHIP_FROM_COUNTRY;
				entity.SHIP_FROM_POSTAL_CODE = model.SHIP_FROM_POSTAL_CODE;
				entity.SHIP_FROM_NAME = model.SHIP_FROM_NAME;
				entity.SHIP_FROM_ATTENTION_TO = model.SHIP_FROM_ATTENTION_TO;
				entity.SHIP_FROM_EMAIL_ADDRESS = model.SHIP_FROM_EMAIL_ADDRESS;
				entity.SHIP_FROM_PHONE_NUM = model.SHIP_FROM_PHONE_NUM;
				entity.SHIP_FROM_FAX_NUM = model.SHIP_FROM_FAX_NUM;
				entity.SCHEDULED_ARRIVE_DATE = model.SCHEDULED_ARRIVE_DATE;
				entity.ACTUAL_ARRIVE_DATE = model.ACTUAL_ARRIVE_DATE;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.PURCHASE_ORDER_HEADER entity = m_Rep.GetById(model.INTERNAL_PURCHASE_ORDER_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_PURCHASE_ORDER_NUM = model.INTERNAL_PURCHASE_ORDER_NUM;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.COMPANY = model.COMPANY;
											entity.PURCHASE_ORDER_ID = model.PURCHASE_ORDER_ID;
											entity.PURCHASE_ORDER_TYPE = model.PURCHASE_ORDER_TYPE;
											entity.CLOSE_DATE = model.CLOSE_DATE;
											entity.PRIORITY = model.PRIORITY;
											entity.STATUS = model.STATUS;
											entity.ERP_ORDER_ID = model.ERP_ORDER_ID;
											entity.SHIP_FROM = model.SHIP_FROM;
											entity.SHIP_FROM_ADDRESS1 = model.SHIP_FROM_ADDRESS1;
											entity.SHIP_FROM_ADDRESS2 = model.SHIP_FROM_ADDRESS2;
											entity.SHIP_FROM_CITY = model.SHIP_FROM_CITY;
											entity.SHIP_FROM_STATE = model.SHIP_FROM_STATE;
											entity.SHIP_FROM_COUNTRY = model.SHIP_FROM_COUNTRY;
											entity.SHIP_FROM_POSTAL_CODE = model.SHIP_FROM_POSTAL_CODE;
											entity.SHIP_FROM_NAME = model.SHIP_FROM_NAME;
											entity.SHIP_FROM_ATTENTION_TO = model.SHIP_FROM_ATTENTION_TO;
											entity.SHIP_FROM_EMAIL_ADDRESS = model.SHIP_FROM_EMAIL_ADDRESS;
											entity.SHIP_FROM_PHONE_NUM = model.SHIP_FROM_PHONE_NUM;
											entity.SHIP_FROM_FAX_NUM = model.SHIP_FROM_FAX_NUM;
											entity.SCHEDULED_ARRIVE_DATE = model.SCHEDULED_ARRIVE_DATE;
											entity.ACTUAL_ARRIVE_DATE = model.ACTUAL_ARRIVE_DATE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL);
						Type typeE = typeof(Apps.Models.PURCHASE_ORDER_HEADER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL GetById(string id)
		{
			Apps.Models.PURCHASE_ORDER_HEADER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//PURCHASE_ORDER_HEADER entity = m_Rep.GetById(id);
				Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL model = new Apps.Models.SCV.PURCHASE.PURCHASE_ORDER_HEADER_MODEL();
							  				model.INTERNAL_PURCHASE_ORDER_NUM = entity.INTERNAL_PURCHASE_ORDER_NUM;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.COMPANY = entity.COMPANY;
				model.PURCHASE_ORDER_ID = entity.PURCHASE_ORDER_ID;
				model.PURCHASE_ORDER_TYPE = entity.PURCHASE_ORDER_TYPE;
				model.CLOSE_DATE = entity.CLOSE_DATE;
				model.PRIORITY = entity.PRIORITY;
				model.STATUS = entity.STATUS;
				model.ERP_ORDER_ID = entity.ERP_ORDER_ID;
				model.SHIP_FROM = entity.SHIP_FROM;
				model.SHIP_FROM_ADDRESS1 = entity.SHIP_FROM_ADDRESS1;
				model.SHIP_FROM_ADDRESS2 = entity.SHIP_FROM_ADDRESS2;
				model.SHIP_FROM_CITY = entity.SHIP_FROM_CITY;
				model.SHIP_FROM_STATE = entity.SHIP_FROM_STATE;
				model.SHIP_FROM_COUNTRY = entity.SHIP_FROM_COUNTRY;
				model.SHIP_FROM_POSTAL_CODE = entity.SHIP_FROM_POSTAL_CODE;
				model.SHIP_FROM_NAME = entity.SHIP_FROM_NAME;
				model.SHIP_FROM_ATTENTION_TO = entity.SHIP_FROM_ATTENTION_TO;
				model.SHIP_FROM_EMAIL_ADDRESS = entity.SHIP_FROM_EMAIL_ADDRESS;
				model.SHIP_FROM_PHONE_NUM = entity.SHIP_FROM_PHONE_NUM;
				model.SHIP_FROM_FAX_NUM = entity.SHIP_FROM_FAX_NUM;
				model.SCHEDULED_ARRIVE_DATE = entity.SCHEDULED_ARRIVE_DATE;
				model.ACTUAL_ARRIVE_DATE = entity.ACTUAL_ARRIVE_DATE;
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
