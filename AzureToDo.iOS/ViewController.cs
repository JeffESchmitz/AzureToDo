using System;

using UIKit;

namespace AzureToDo
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			AddButton.TouchUpInside += async (sender, e) => {
				const string foobar = "Foobar!";
				TitleLabel.Text = foobar;
				Item item = new Item { Text = foobar };
				await AppDelegate.mobileServiceClient.GetTable<Item>().InsertAsync (item);
			};

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

