// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monobjc.Samples.DeviceListener {
	using Monobjc;
	using Monobjc.AppKit;
	
	
	public partial class AppController {
		
		[IBOutlet()]
		[ObjectiveCIVar("textView")]
		public virtual NSTextView textView {
			get {
				return this.GetInstanceVariable <NSTextView>("textView");
			}
			set {
				this.SetInstanceVariable <NSTextView>("textView", value);
			}
		}
	}
}
