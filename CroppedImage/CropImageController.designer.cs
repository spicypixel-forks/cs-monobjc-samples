// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monobjc.Samples.CroppedImage {
	using Monobjc;
	using Monobjc.AppKit;
	using Monobjc.Samples.CroppedImage;
	
	
	public partial class CropImageController {
		
		partial void ImageChanged(Id sender);

		partial void OpenDocument(Id sender);

		partial void SaveDocument(Id sender);

		partial void ShowTheApe(Id sender);

		[IBOutlet()]
		[ObjectiveCIVar("antiAliasCheckbox")]
		public virtual NSButtonCell antiAliasCheckbox {
			get {
				return this.GetInstanceVariable <NSButtonCell>("antiAliasCheckbox");
			}
			set {
				this.SetInstanceVariable <NSButtonCell>("antiAliasCheckbox", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("colorWell")]
		public virtual NSColorWell colorWell {
			get {
				return this.GetInstanceVariable <NSColorWell>("colorWell");
			}
			set {
				this.SetInstanceVariable <NSColorWell>("colorWell", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("continousModeCheckbox")]
		public virtual NSButtonCell continousModeCheckbox {
			get {
				return this.GetInstanceVariable <NSButtonCell>("continousModeCheckbox");
			}
			set {
				this.SetInstanceVariable <NSButtonCell>("continousModeCheckbox", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("croppedImageView")]
		public virtual NSImageView croppedImageView {
			get {
				return this.GetInstanceVariable <NSImageView>("croppedImageView");
			}
			set {
				this.SetInstanceVariable <NSImageView>("croppedImageView", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("imageView")]
		public virtual CroppingImageView imageView {
			get {
				return this.GetInstanceVariable <CroppingImageView>("imageView");
			}
			set {
				this.SetInstanceVariable <CroppingImageView>("imageView", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("popUp")]
		public virtual NSPopUpButton popUp {
			get {
				return this.GetInstanceVariable <NSPopUpButton>("popUp");
			}
			set {
				this.SetInstanceVariable <NSPopUpButton>("popUp", value);
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
		[ObjectiveCMessage("imageChanged:")]
		public virtual void __ImageChanged(Id sender) {
			this.ImageChanged(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("openDocument:")]
		public virtual void __OpenDocument(Id sender) {
			this.OpenDocument(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("saveDocument:")]
		public virtual void __SaveDocument(Id sender) {
			this.SaveDocument(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("showTheApe:")]
		public virtual void __ShowTheApe(Id sender) {
			this.ShowTheApe(sender);
		}
	}
}