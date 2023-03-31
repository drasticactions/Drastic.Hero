using System;
using Hero;

#nullable disable

namespace Drastic.HeroSamples
{
    public class BasicViewController2 : UIViewController
    {
        private UIView view1 = new UIView();
        private UIView view2 = new UIView();
        private UIButton button = new UIButton(UIButtonType.RoundedRect);
        private UIView view3 = new UIView();

        public BasicViewController2()
        {
            SetupUI();
            SetupLayout();
            this.button.PrimaryActionTriggered += Button_PrimaryActionTriggered;
        }

        private void Button_PrimaryActionTriggered(object sender, EventArgs e)
        {
            DismissViewController(true, null);
        }

        private void SetupUI()
        {
            Title = "Basic";

            SetValueForKey(new NSNumber(true), new NSString("isHeroEnabled"));

            View.AddSubview(view1);
            View.AddSubview(view2);
            View.AddSubview(view3);
            View.AddSubview(button);

            button.ContentEdgeInsets = new UIEdgeInsets(20, 40, 20, 40);
            button.VerticalAlignment = UIControlContentVerticalAlignment.Center;
            button.TitleLabel.LineBreakMode = UILineBreakMode.MiddleTruncation;
            button.TranslatesAutoresizingMaskIntoConstraints = false;
            button.SetTitle("Back", UIControlState.Normal);
            button.AddTarget(null, new ObjCRuntime.Selector("hero_dismissViewController"), UIControlEvent.PrimaryActionTriggered);

            button.SetValueForKey(new NSString("next"), new NSString("heroID"));

            view3.BackgroundColor = UIColor.FromRGB(166, 125, 193);
            view3.TranslatesAutoresizingMaskIntoConstraints = false;

            view3.SetValueForKey(new NSString("arc"), new NSString("heroModifierString"));
            view3.SetValueForKey(new NSString("purple"), new NSString("heroID"));
            view3.SetValueForKey(new NSNumber(7), new NSString("cornerRadius"));

            view2.BackgroundColor = UIColor.FromRGB(87, 187, 138);
            view2.TranslatesAutoresizingMaskIntoConstraints = false;

            view2.SetValueForKey(new NSString("green"), new NSString("heroID"));
            view2.SetValueForKey(new NSNumber(7), new NSString("cornerRadius"));

            view1.BackgroundColor = UIColor.FromRGB(82, 159, 205);
            view1.TranslatesAutoresizingMaskIntoConstraints = false;

            view1.SetValueForKey(new NSString("arc(-1)"), new NSString("heroModifierString"));
            view1.SetValueForKey(new NSString("blue"), new NSString("heroID"));
            view1.SetValueForKey(new NSNumber(7), new NSString("cornerRadius"));
        }

        private void SetupLayout()
        {
            button.TopAnchor.ConstraintEqualTo(view3.BottomAnchor, 48).Active = true;
            view1.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor, -280).Active = true;
            view2.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor, -40).Active = true;
            view3.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            view3.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor, 200).Active = true;
            view1.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            view2.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            button.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;

            view3.WidthAnchor.ConstraintEqualTo(500).Active = true;
            view3.HeightAnchor.ConstraintEqualTo(200).Active = true;

            view2.HeightAnchor.ConstraintEqualTo(200).Active = true;
            view2.WidthAnchor.ConstraintEqualTo(500).Active = true;

            view1.HeightAnchor.ConstraintEqualTo(200).Active = true;
            view1.WidthAnchor.ConstraintEqualTo(500).Active = true;
        }
    }

    public class BasicViewController : UIViewController
    {
        private UIView view1 = new UIView();
        private UIView view2 = new UIView();
        private UIButton button = new UIButton(UIButtonType.RoundedRect);
        private UIView view3 = new UIView();

        public BasicViewController()
        {
            SetupUI();
            SetupLayout();
            this.button.PrimaryActionTriggered += Button_PrimaryActionTriggered;
        }

        private void Button_PrimaryActionTriggered(object sender, EventArgs e)
        {
            var vc2 = new BasicViewController2();
            vc2.SetHeroEnabled(true);
            PresentViewController(vc2, true, null);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        private void SetupUI()
        {
            Title = "Basic";

            View.AddSubview(view1);
            View.AddSubview(view2);
            View.AddSubview(button);
            View.AddSubview(view3);

            view3.BackgroundColor = UIColor.FromRGB(82, 159, 205);
            view3.TranslatesAutoresizingMaskIntoConstraints = false;

            view3.SetValueForKey(new NSString("arc(-1)"), new NSString("heroModifierString"));
            view3.SetValueForKey(new NSString("blue"), new NSString("heroID"));
            view3.SetValueForKey(new NSNumber(7), new NSString("cornerRadius"));

            button.ContentEdgeInsets = new UIEdgeInsets(20, 40, 20, 40);
            button.VerticalAlignment = UIControlContentVerticalAlignment.Center;
            button.TitleLabel.LineBreakMode = UILineBreakMode.MiddleTruncation;
            button.TranslatesAutoresizingMaskIntoConstraints = false;
            button.SetTitle("Next", UIControlState.Normal);

            button.SetValueForKey(new NSString("next"), new NSString("heroID"));

            view2.BackgroundColor = UIColor.FromRGB(166, 125, 193);
            view2.TranslatesAutoresizingMaskIntoConstraints = false;

            view2.SetValueForKey(new NSString("1"), new NSString("heroModifierString"));
            view2.SetValueForKey(new NSString("purple"), new NSString("heroID"));
            view2.SetValueForKey(new NSNumber(7), new NSString("cornerRadius"));

            view1.BackgroundColor = UIColor.FromRGB(87, 187, 138);
            view1.TranslatesAutoresizingMaskIntoConstraints = false;

            view1.SetValueForKey(new NSString("green"), new NSString("heroID"));
            view1.SetValueForKey(new NSNumber(7), new NSString("cornerRadius"));
        }

        private void SetupLayout()
        {
            view3.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor).Active = true;
            view2.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor).Active = true;
            view2.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor, 480).Active = true;
            view3.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor, -480).Active = true;
            button.TopAnchor.ConstraintEqualTo(view1.BottomAnchor, 120).Active = true;
            view1.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            button.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            view1.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor).Active = true;

            view3.HeightAnchor.ConstraintEqualTo(250).Active = true;
            view3.WidthAnchor.ConstraintEqualTo(250).Active = true;

            view2.WidthAnchor.ConstraintEqualTo(250).Active = true;
            view2.HeightAnchor.ConstraintEqualTo(250).Active = true;

            view1.HeightAnchor.ConstraintEqualTo(250).Active = true;
            view1.WidthAnchor.ConstraintEqualTo(250).Active = true;
        }
    }
}

