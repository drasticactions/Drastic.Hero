using System;
using Hero;

namespace Drastic.HeroSamples
{
    public class ExampleBaseViewController : UIViewController
    {
        readonly UIButton dismissButton = new UIButton(UIButtonType.System);

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

#if !TVOS
            View!.BackgroundColor = UIColor.SystemBackground;
#else
            View.BackgroundColor = UIColor.White;
#endif

            View.AddGestureRecognizer(new UITapGestureRecognizer(OnTap));

            dismissButton.SetTitle("Back", UIControlState.Normal);
            dismissButton.AddTarget(this, new ObjCRuntime.Selector("back"), UIControlEvent.TouchUpInside);
            dismissButton.SetHeroID("back button");
            View.AddSubview(dismissButton);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            dismissButton.SizeToFit();
            dismissButton.Center = new CGPoint(30, 30);
        }

        [Export("back")]
        void Back()
        {
            DismissViewController(true, null);
        }

        public virtual void OnTap()
        {
            Back();
        }
    }
}