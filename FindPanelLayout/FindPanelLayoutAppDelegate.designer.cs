// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace net.monobjc.samples.FindPanelLayout {
	using Monobjc;
	using Monobjc.AppKit;
	
	
	public partial class FindPanelLayoutAppDelegate {
		
		[IBOutlet()]
		[ObjectiveCIVar("window")]
		public virtual NSWindow window {
			get {
				return this.GetInstanceVariable <NSWindow>("window");
			}
			set {
				this.SetInstanceVariable <NSWindow>("window", value);
			}
		}
	}
}
