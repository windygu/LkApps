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
namespace Apps.Service.SCV.DOWNLOAD
{
	public class Virtual_DOWNLOAD_ITEMS_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.DOWNLOAD.IDOWNLOAD_ITEMS_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.DOWNLOAD_ITEMS;
			}
		}
		

		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL> GetList(Expression<Func<Apps.Models.DOWNLOAD_ITEMS, bool>> where = null){
		
				IQueryable<Apps.Models.DOWNLOAD_ITEMS> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.DOWNLOAD_ITEMS, bool>> where,Expression<Func<Apps.Models.DOWNLOAD_ITEMS, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.DOWNLOAD_ITEMS> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.DOWNLOAD_ITEMS, bool>> where = null)
		{

			IQueryable<Apps.Models.DOWNLOAD_ITEMS> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.INTERFACE_RECORD_ID.Contains(queryStr)
								|| a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.ITEM_DESC.Contains(queryStr)
								|| a.ATTRIBUTE_TRACK.Contains(queryStr)
								|| a.ITEM_STYLE.Contains(queryStr)
								|| a.DEPARTMENT.Contains(queryStr)
								|| a.ITEM_CATEGORY1.Contains(queryStr)
								|| a.ITEM_CATEGORY2.Contains(queryStr)
								|| a.ITEM_CATEGORY3.Contains(queryStr)
								|| a.ITEM_CATEGORY4.Contains(queryStr)
								|| a.ITEM_CATEGORY5.Contains(queryStr)
								|| a.ITEM_CATEGORY6.Contains(queryStr)
								|| a.ITEM_CATEGORY7.Contains(queryStr)
								|| a.ITEM_CATEGORY8.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
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
		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL> CreateModelList(ref IQueryable<Apps.Models.DOWNLOAD_ITEMS> queryData)
		{

			List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													PROCESS_STAMP = r.PROCESS_STAMP,
													COMPANY = r.COMPANY,
													ITEM = r.ITEM,
													ITEM_DESC = r.ITEM_DESC,
													ATTRIBUTE_TRACK = r.ATTRIBUTE_TRACK,
													ITEM_STYLE = r.ITEM_STYLE,
													DEPARTMENT = r.DEPARTMENT,
													ITEM_CATEGORY1 = r.ITEM_CATEGORY1,
													ITEM_CATEGORY2 = r.ITEM_CATEGORY2,
													ITEM_CATEGORY3 = r.ITEM_CATEGORY3,
													ITEM_CATEGORY4 = r.ITEM_CATEGORY4,
													ITEM_CATEGORY5 = r.ITEM_CATEGORY5,
													ITEM_CATEGORY6 = r.ITEM_CATEGORY6,
													ITEM_CATEGORY7 = r.ITEM_CATEGORY7,
													ITEM_CATEGORY8 = r.ITEM_CATEGORY8,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL model)
		{
				Apps.Models.DOWNLOAD_ITEMS entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.DOWNLOAD_ITEMS();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.COMPANY = model.COMPANY;
				entity.ITEM = model.ITEM;
				entity.ITEM_DESC = model.ITEM_DESC;
				entity.ATTRIBUTE_TRACK = model.ATTRIBUTE_TRACK;
				entity.ITEM_STYLE = model.ITEM_STYLE;
				entity.DEPARTMENT = model.DEPARTMENT;
				entity.ITEM_CATEGORY1 = model.ITEM_CATEGORY1;
				entity.ITEM_CATEGORY2 = model.ITEM_CATEGORY2;
				entity.ITEM_CATEGORY3 = model.ITEM_CATEGORY3;
				entity.ITEM_CATEGORY4 = model.ITEM_CATEGORY4;
				entity.ITEM_CATEGORY5 = model.ITEM_CATEGORY5;
				entity.ITEM_CATEGORY6 = model.ITEM_CATEGORY6;
				entity.ITEM_CATEGORY7 = model.ITEM_CATEGORY7;
				entity.ITEM_CATEGORY8 = model.ITEM_CATEGORY8;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL model,params string[] updateProperties)
		{
				Apps.Models.DOWNLOAD_ITEMS entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
											entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
											entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
											entity.PROCESS_STAMP = model.PROCESS_STAMP;
											entity.COMPANY = model.COMPANY;
											entity.ITEM = model.ITEM;
											entity.ITEM_DESC = model.ITEM_DESC;
											entity.ATTRIBUTE_TRACK = model.ATTRIBUTE_TRACK;
											entity.ITEM_STYLE = model.ITEM_STYLE;
											entity.DEPARTMENT = model.DEPARTMENT;
											entity.ITEM_CATEGORY1 = model.ITEM_CATEGORY1;
											entity.ITEM_CATEGORY2 = model.ITEM_CATEGORY2;
											entity.ITEM_CATEGORY3 = model.ITEM_CATEGORY3;
											entity.ITEM_CATEGORY4 = model.ITEM_CATEGORY4;
											entity.ITEM_CATEGORY5 = model.ITEM_CATEGORY5;
											entity.ITEM_CATEGORY6 = model.ITEM_CATEGORY6;
											entity.ITEM_CATEGORY7 = model.ITEM_CATEGORY7;
											entity.ITEM_CATEGORY8 = model.ITEM_CATEGORY8;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL);
						Type typeE = typeof(Apps.Models.DOWNLOAD_ITEMS);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL GetById(string id)
		{
			Apps.Models.DOWNLOAD_ITEMS entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//DOWNLOAD_ITEMS entity = m_Rep.GetById(id);
				Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL model = new Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEMS_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.COMPANY = entity.COMPANY;
				model.ITEM = entity.ITEM;
				model.ITEM_DESC = entity.ITEM_DESC;
				model.ATTRIBUTE_TRACK = entity.ATTRIBUTE_TRACK;
				model.ITEM_STYLE = entity.ITEM_STYLE;
				model.DEPARTMENT = entity.DEPARTMENT;
				model.ITEM_CATEGORY1 = entity.ITEM_CATEGORY1;
				model.ITEM_CATEGORY2 = entity.ITEM_CATEGORY2;
				model.ITEM_CATEGORY3 = entity.ITEM_CATEGORY3;
				model.ITEM_CATEGORY4 = entity.ITEM_CATEGORY4;
				model.ITEM_CATEGORY5 = entity.ITEM_CATEGORY5;
				model.ITEM_CATEGORY6 = entity.ITEM_CATEGORY6;
				model.ITEM_CATEGORY7 = entity.ITEM_CATEGORY7;
				model.ITEM_CATEGORY8 = entity.ITEM_CATEGORY8;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
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
