using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;
// ADD: CoreAnimation to your ViewController
using CoreAnimation;

namespace Maive
{
	partial class ProfileController : UIViewController
	{
		public ProfileController (IntPtr handle) : base (handle)
		{

			
		}

		public override void ViewDidLoad()
		{
			// on page load we will show the current user's First Name from Parse
			var currentUser = ParseUser.CurrentUser;
			lblWelcome.Text = "Welcome, " + currentUser["FirstName"];
		}
	}
}


