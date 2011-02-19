// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monobjc.Samples.BackgroundWorkerApp {
	using Monobjc;
	using Monobjc.AppKit;
	
	
	public partial class AppController {
		
		partial void Start(Id sender);

		partial void Stop(Id sender);

		[IBOutlet()]
		[ObjectiveCIVar("buttonStart")]
		public virtual NSButton buttonStart {
			get {
				return this.GetInstanceVariable <NSButton>("buttonStart");
			}
			set {
				this.SetInstanceVariable <NSButton>("buttonStart", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("buttonStop")]
		public virtual NSButton buttonStop {
			get {
				return this.GetInstanceVariable <NSButton>("buttonStop");
			}
			set {
				this.SetInstanceVariable <NSButton>("buttonStop", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("labelResult")]
		public virtual NSTextField labelResult {
			get {
				return this.GetInstanceVariable <NSTextField>("labelResult");
			}
			set {
				this.SetInstanceVariable <NSTextField>("labelResult", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("progressIndicator")]
		public virtual NSProgressIndicator progressIndicator {
			get {
				return this.GetInstanceVariable <NSProgressIndicator>("progressIndicator");
			}
			set {
				this.SetInstanceVariable <NSProgressIndicator>("progressIndicator", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("sliderIterations")]
		public virtual NSSlider sliderIterations {
			get {
				return this.GetInstanceVariable <NSSlider>("sliderIterations");
			}
			set {
				this.SetInstanceVariable <NSSlider>("sliderIterations", value);
			}
		}
		
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
		
		[IBAction()]
		[ObjectiveCMessage("start:")]
		public virtual void __Start(Id sender) {
			this.Start(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("stop:")]
		public virtual void __Stop(Id sender) {
			this.Stop(sender);
		}
	}
}
