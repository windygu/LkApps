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
	public partial class WAVE_FLOW_HEADER
	{
		public Apps.Models.SCV.WAVE.WAVE_FLOW_HEADER_MODEL ToPOCO(){
			return new Apps.Models.SCV.WAVE.WAVE_FLOW_HEADER_MODEL(){
								WAVE_FLOW=this.WAVE_FLOW,
				DESCRIPTION=this.DESCRIPTION,
				ACTIVE=this.ACTIVE,
				OBJECT_ID=this.OBJECT_ID,
				CREATE_TASK=this.CREATE_TASK,
			};
		}
	}
}
