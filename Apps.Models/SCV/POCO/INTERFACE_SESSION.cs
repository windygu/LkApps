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
	public partial class INTERFACE_SESSION
	{
		public Apps.Models.SCV.INTERFACE.INTERFACE_SESSION_MODEL ToPOCO(){
			return new Apps.Models.SCV.INTERFACE.INTERFACE_SESSION_MODEL(){
								INTERNAL_SESS_NUM=this.INTERNAL_SESS_NUM,
				WAREHOUSE=this.WAREHOUSE,
				COMPANY=this.COMPANY,
				USER_ID=this.USER_ID,
				APPKEY=this.APPKEY,
				PASSWORD=this.PASSWORD,
				TOKEN=this.TOKEN,
				REFRESH_TOKEN=this.REFRESH_TOKEN,
				REDIRECT_URL=this.REDIRECT_URL,
				SANDBOX=this.SANDBOX,
				ACTIVE=this.ACTIVE,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				USER_STAMP=this.USER_STAMP,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
			};
		}
	}
}
