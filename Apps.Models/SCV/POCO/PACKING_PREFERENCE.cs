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
	public partial class PACKING_PREFERENCE
	{
		public Apps.Models.SCV.PACKING.PACKING_PREFERENCE_MODEL ToPOCO(){
			return new Apps.Models.SCV.PACKING.PACKING_PREFERENCE_MODEL(){
								INTERNAL_PREF_NUM=this.INTERNAL_PREF_NUM,
				PREFERENCE_NAME=this.PREFERENCE_NAME,
				AUTO_ASSIGN_CONTAINER_ID=this.AUTO_ASSIGN_CONTAINER_ID,
			};
		}
	}
}
