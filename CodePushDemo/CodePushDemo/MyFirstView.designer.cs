// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CodePushDemo
{
	[Register ("MyFirstView")]
	partial class MyFirstView
	{
		[Outlet]
		UIKit.UIButton btnTest { get; set; }

		[Outlet]
		UIKit.UITextField txtField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtField != null) {
				txtField.Dispose ();
				txtField = null;
			}

			if (btnTest != null) {
				btnTest.Dispose ();
				btnTest = null;
			}
		}
	}
}
