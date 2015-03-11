// MailCellTemplate.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	[Foundation.Register("MailCellTemplate")]
	partial class MailCellTemplate
	{
		[Foundation.Outlet]
		UIKit.UILabel DateLabel { get; set; }

		[Foundation.Outlet]
		UIKit.UILabel FromLabel { get; set; }

		[Foundation.Outlet]
		UIKit.UILabel SubjectLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FromLabel != null) {
				FromLabel.Dispose ();
				FromLabel = null;
			}

			if (SubjectLabel != null) {
				SubjectLabel.Dispose ();
				SubjectLabel = null;
			}

			if (DateLabel != null) {
				DateLabel.Dispose ();
				DateLabel = null;
			}
		}
	}
}
