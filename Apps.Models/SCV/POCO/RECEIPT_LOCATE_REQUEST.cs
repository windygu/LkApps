//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
	public partial class RECEIPT_LOCATE_REQUEST
	{
		public Apps.Models.SCV.RECEIPT.RECEIPT_LOCATE_REQUEST_MODEL ToPOCO(){
			return new Apps.Models.SCV.RECEIPT.RECEIPT_LOCATE_REQUEST_MODEL(){
								INTERNAL_REC_LOC_NUM=this.INTERNAL_REC_LOC_NUM,
				WAREHOUSE=this.WAREHOUSE,
				COMPANY=this.COMPANY,
				INTERNAL_CONTAINER_NUM=this.INTERNAL_CONTAINER_NUM,
				CONTAINER_ID=this.CONTAINER_ID,
				ITEM=this.ITEM,
				ITEM_DESC=this.ITEM_DESC,
				LOCATE_QTY=this.LOCATE_QTY,
				QUANTITY_UM=this.QUANTITY_UM,
				ATTRIBUTE_NUM=this.ATTRIBUTE_NUM,
				INVENTORY_STS=this.INVENTORY_STS,
				FROM_LOC=this.FROM_LOC,
				TO_LOC=this.TO_LOC,
				FROM_TEMPLATE_FIELD1=this.FROM_TEMPLATE_FIELD1,
				FROM_TEMPLATE_FIELD2=this.FROM_TEMPLATE_FIELD2,
				FROM_TEMPLATE_FIELD3=this.FROM_TEMPLATE_FIELD3,
				FROM_TEMPLATE_FIELD4=this.FROM_TEMPLATE_FIELD4,
				FROM_TEMPLATE_FIELD5=this.FROM_TEMPLATE_FIELD5,
				TO_TEMPLATE_FIELD1=this.TO_TEMPLATE_FIELD1,
				TO_TEMPLATE_FIELD2=this.TO_TEMPLATE_FIELD2,
				TO_TEMPLATE_FIELD3=this.TO_TEMPLATE_FIELD3,
				TO_TEMPLATE_FIELD4=this.TO_TEMPLATE_FIELD4,
				TO_TEMPLATE_FIELD5=this.TO_TEMPLATE_FIELD5,
				ZONE=this.ZONE,
				CONVERTED_QTY=this.CONVERTED_QTY,
				CONVERTED_QTY_UM=this.CONVERTED_QTY_UM,
				TASK_CREATED=this.TASK_CREATED,
				RECEIPT_ID=this.RECEIPT_ID,
				RECEIPT_TYPE=this.RECEIPT_TYPE,
				RECEIPT_DATE=this.RECEIPT_DATE,
				PARENT_CONTAINER_NUM=this.PARENT_CONTAINER_NUM,
				PARENT_CONTAINER_ID=this.PARENT_CONTAINER_ID,
				INTERNAL_RECEIPT_NUM=this.INTERNAL_RECEIPT_NUM,
				INTERNAL_RECEIPT_LINE_NUM=this.INTERNAL_RECEIPT_LINE_NUM,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				INTERNAL_WAVE_NUM=this.INTERNAL_WAVE_NUM,
			};
		}
	}
}
