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
	public partial class RECEIVING_PREFERENCE
	{
		public Apps.Models.SCV.RECEIVING.RECEIVING_PREFERENCE_MODEL ToPOCO(){
			return new Apps.Models.SCV.RECEIVING.RECEIVING_PREFERENCE_MODEL(){
								INTERNAL_PREF_NUM=this.INTERNAL_PREF_NUM,
				PREFERENCE_NAME=this.PREFERENCE_NAME,
				WAREHOUSE=this.WAREHOUSE,
				AUTO_ASSIGN_LPN=this.AUTO_ASSIGN_LPN,
				AUTO_PUTAWAY=this.AUTO_PUTAWAY,
				ALLOW_OVER_RECEIVING=this.ALLOW_OVER_RECEIVING,
				ACTIVE=this.ACTIVE,
				AUTO_LOCATE=this.AUTO_LOCATE,
				AUTO_CHECKIN=this.AUTO_CHECKIN,
				SHOW_OPEN_QTY=this.SHOW_OPEN_QTY,
				RECEIPT_TYPES=this.RECEIPT_TYPES,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				GROUP_PUTAWAY=this.GROUP_PUTAWAY,
				NEST_DURING_CHECKIN=this.NEST_DURING_CHECKIN,
				MANUALLY_BUILD_LPN=this.MANUALLY_BUILD_LPN,
				CREATE_DATE_TIME=this.CREATE_DATE_TIME,
				CREATE_USER=this.CREATE_USER,
				LAST_MODIFY_DATE_TIME=this.LAST_MODIFY_DATE_TIME,
				LAST_MODIFY_USER=this.LAST_MODIFY_USER,
				RULE_ASSIGNMENT=this.RULE_ASSIGNMENT,
				RECEIPT_BY_PIECE=this.RECEIPT_BY_PIECE,
				RECEIPT_AUTOMATIC_CONFIRM=this.RECEIPT_AUTOMATIC_CONFIRM,
			};
		}
	}
}
