// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monobjc.Samples.AddressBookCocoa {
	using Monobjc;
	using Monobjc.AppKit;
	
	
	public partial class MyObject {
		
		partial void AddElba(Id sender);

		partial void FindElba(Id sender);

		[IBOutlet()]
		[ObjectiveCIVar("addElbaButton")]
		public virtual NSButton addElbaButton {
			get {
				return this.GetInstanceVariable <NSButton>("addElbaButton");
			}
			set {
				this.SetInstanceVariable <NSButton>("addElbaButton", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("findElbaButton")]
		public virtual NSButton findElbaButton {
			get {
				return this.GetInstanceVariable <NSButton>("findElbaButton");
			}
			set {
				this.SetInstanceVariable <NSButton>("findElbaButton", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("firstName")]
		public virtual NSTextField firstName {
			get {
				return this.GetInstanceVariable <NSTextField>("firstName");
			}
			set {
				this.SetInstanceVariable <NSTextField>("firstName", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("matchingRecords")]
		public virtual NSTextField matchingRecords {
			get {
				return this.GetInstanceVariable <NSTextField>("matchingRecords");
			}
			set {
				this.SetInstanceVariable <NSTextField>("matchingRecords", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("streetAddr")]
		public virtual NSTextField streetAddr {
			get {
				return this.GetInstanceVariable <NSTextField>("streetAddr");
			}
			set {
				this.SetInstanceVariable <NSTextField>("streetAddr", value);
			}
		}
		
		[IBOutlet()]
		[ObjectiveCIVar("workFaxPhone")]
		public virtual NSTextField workFaxPhone {
			get {
				return this.GetInstanceVariable <NSTextField>("workFaxPhone");
			}
			set {
				this.SetInstanceVariable <NSTextField>("workFaxPhone", value);
			}
		}
		
		[IBAction()]
		[ObjectiveCMessage("addElba:")]
		public virtual void __AddElba(Id sender) {
			this.AddElba(sender);
		}
		
		[IBAction()]
		[ObjectiveCMessage("findElba:")]
		public virtual void __FindElba(Id sender) {
			this.FindElba(sender);
		}
	}
}