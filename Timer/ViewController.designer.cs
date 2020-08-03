// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Timer
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Bathroom { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ResetTimer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Bathroom != null) {
                Bathroom.Dispose ();
                Bathroom = null;
            }

            if (ResetTimer != null) {
                ResetTimer.Dispose ();
                ResetTimer = null;
            }
        }
    }
}