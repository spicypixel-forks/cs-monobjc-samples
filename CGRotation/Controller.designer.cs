// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monobjc.Samples.CGRotation {
	using Monobjc;
	using Monobjc.Samples.CGRotation;
	using Monobjc.AppKit;
	
	
	public partial class Controller {
		
		partial void ChangeScaleX(Id sender);

		partial void ChangeScaleY(Id sender);

		partial void ChangeTranslateX(Id sender);

		partial void ChangeTranslateY(Id sender);

		partial void OpenDocument(Id sender);

		partial void Reset(Id sender);

		partial void SaveDocumentAs(Id sender);

		[IBOutlet()]
		[ObjectiveCIVar("imageView")]
		public virtual ImageView imageView {
			get {
				return this.GetInstanceVariable <ImageView>("imageView");
			}
			set {
				this.SetInstanceVariable <ImageView>("imageView", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("scaleYView")]
		public virtual NSStepper scaleYView {
			get {
				return this.GetInstanceVariable <NSStepper>("scaleYView");
			}
			set {
				this.SetInstanceVariable <NSStepper>("scaleYView", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("textLabelXView")]
		public virtual NSTextField textLabelXView {
			get {
				return this.GetInstanceVariable <NSTextField>("textLabelXView");
			}
			set {
				this.SetInstanceVariable <NSTextField>("textLabelXView", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("textLabelYView")]
		public virtual NSTextField textLabelYView {
			get {
				return this.GetInstanceVariable <NSTextField>("textLabelYView");
			}
			set {
				this.SetInstanceVariable <NSTextField>("textLabelYView", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("textScaleYView")]
		public virtual NSTextField textScaleYView {
			get {
				return this.GetInstanceVariable <NSTextField>("textScaleYView");
			}
			set {
				this.SetInstanceVariable <NSTextField>("textScaleYView", value);
			}
		}
		
		[IBAction()]
		[ObjectiveCMessage("changeScaleX:")]
		public virtual void __ChangeScaleX(Id sender) {
			this.ChangeScaleX(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("changeScaleY:")]
		public virtual void __ChangeScaleY(Id sender) {
			this.ChangeScaleY(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("changeTranslateX:")]
		public virtual void __ChangeTranslateX(Id sender) {
			this.ChangeTranslateX(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("changeTranslateY:")]
		public virtual void __ChangeTranslateY(Id sender) {
			this.ChangeTranslateY(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("openDocument:")]
		public virtual void __OpenDocument(Id sender) {
			this.OpenDocument(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("reset:")]
		public virtual void __Reset(Id sender) {
			this.Reset(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("saveDocumentAs:")]
		public virtual void __SaveDocumentAs(Id sender) {
			this.SaveDocumentAs(sender);
		}
	}
}
