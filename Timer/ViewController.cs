using Foundation;
using System;
using UIKit;

using System.Diagnostics;
using System.Threading;

using Foundation;

namespace Timer
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            Stopwatch startTime = new Stopwatch();
            TimeSpan stopTime = new TimeSpan();

            bool pressed = false;
            int count = 0;
            Bathroom.TouchUpInside += (object sender, EventArgs e) =>
            {
                count++;
                if (count == 1)
                {
                    startTime = KeepTime.StartTimer();
                    Bathroom.BackgroundColor = UIColor.Red;
                    Bathroom.SetTitle($"Counting...", UIControlState.Normal);
                }
                if (count == 2) 
                {
                    count = count-2;
                    stopTime += KeepTime.StopTimer(startTime);
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    stopTime.Hours, stopTime.Minutes, stopTime.Seconds,
                    stopTime.Milliseconds / 10);
                    Bathroom.BackgroundColor = UIColor.SystemGreenColor;
                    Bathroom.SetTitle($"Bathroom - {elapsedTime}", UIControlState.Normal);
                    
                }

            };

            ResetTimer.TouchUpInside += (object sender, EventArgs e) =>
            {
                stopTime = TimeSpan.Zero;
                string elapsedTime = "00:00:00:00";
                Bathroom.SetTitle($"Bathroom - {elapsedTime}", UIControlState.Normal);
            };
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}