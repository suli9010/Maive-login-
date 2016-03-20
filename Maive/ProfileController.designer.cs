// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Maive
{
	[Register ("ProfileController")]
	partial class ProfileController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField lblBio { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblFollowers { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblFollowing { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblWelcome { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationBar Profile { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblBio != null) {
				lblBio.Dispose ();
				lblBio = null;
			}
			if (lblFollowers != null) {
				lblFollowers.Dispose ();
				lblFollowers = null;
			}
			if (lblFollowing != null) {
				lblFollowing.Dispose ();
				lblFollowing = null;
			}
			if (lblWelcome != null) {
				lblWelcome.Dispose ();
				lblWelcome = null;
			}
			if (Profile != null) {
				Profile.Dispose ();
				Profile = null;
			}
		}
	}
}
