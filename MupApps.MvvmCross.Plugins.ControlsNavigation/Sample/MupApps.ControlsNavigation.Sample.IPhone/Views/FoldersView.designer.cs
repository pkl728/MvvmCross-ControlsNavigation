// FoldersView.designer.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Foundation;

namespace MupApps.ControlsNavigation.Sample.IPhone
{
	[Foundation.Register("FoldersView")]
	partial class FoldersView
	{
		[Foundation.Outlet]
		UIKit.UITableView FoldersTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FoldersTable != null) {
				FoldersTable.Dispose ();
				FoldersTable = null;
			}
		}
	}
}
