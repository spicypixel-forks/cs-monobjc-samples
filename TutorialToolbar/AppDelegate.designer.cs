// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TutorialToolbar
{
	using Monobjc;
	using Monobjc.AppKit;
	
	public partial class AppDelegate
	{
		
		[IBOutlet()]
		[ObjectiveCIVar("window")]
		public virtual NSWindow window {
			get {
				return this.GetInstanceVariable <NSWindow> ("window");
			}
			set {
				this.SetInstanceVariable <NSWindow> ("window", value);
			}
		}
	}
}