using System;
using Hero;

namespace Drastic.HeroSamples
{
    public class MatchExampleViewController1 : ExampleBaseViewController
    {
        readonly UIView redView = new UIView();
        readonly UIView blackView = new UIView();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            redView.BackgroundColor = UIColor.FromRGB(252, 58, 94);
            redView.SetHeroID("ironMan");
            redView.Layer.CornerRadius = 8;
            View.AddSubview(redView);

            blackView.BackgroundColor = UIColor.FromRGB(85, 85, 85);
            blackView.SetHeroID("batMan");
            blackView.Layer.CornerRadius = 8;
            View.AddSubview(blackView);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            redView.Frame = new CGRect(0, 0, 200, 200);
            blackView.Frame = new CGRect(0, 0, 200, 80);
            redView.Center = new CGPoint(View.Bounds.GetMidX(), View.Bounds.GetMidY() + 50);
            blackView.Center = new CGPoint(View.Bounds.GetMidX(), View.Bounds.GetMidY() - 90);
        }

        public override void OnTap()
        {
            var vc2 = new MatchExampleViewController2();
            vc2.SetHeroEnabled(true);
            PresentViewController(vc2, true, null);
        }
    }

    public class MatchExampleViewController2 : ExampleBaseViewController
    {
        readonly UIView redView = new UIView();
        readonly UIView blackView = new UIView();
        readonly UIView backgroundView = new UIView();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            redView.BackgroundColor = UIColor.FromRGB(252, 58, 94);
            redView.SetHeroID("ironMan");
            View.InsertSubview(redView, 0);

            blackView.BackgroundColor = UIColor.FromRGB(85, 85, 85);
            blackView.SetHeroID("batMan");
            blackView.Layer.CornerRadius = 8;
            View.AddSubview(blackView);

#if !TVOS
            View!.BackgroundColor = UIColor.SystemBackground;
#else
            View.BackgroundColor = UIColor.White;
#endif

            backgroundView.Layer.CornerRadius = 8;

            backgroundView.Hero().Modifiers = Modifiers.Translate(0, 500);
            //backgroundView.HeroModifiers = new[] { HeroModifier.TranslateY(500), HeroModifier.UseGlobalCoordinateSpace };
            View.AddSubview(backgroundView);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            redView.Frame = View.Bounds;
            blackView.Frame = new CGRect(0, 0, 250, 60);
            blackView.Center = new CGPoint(View.Bounds.GetMidX(), 130);
            backgroundView.Frame = new CGRect((View.Bounds.Width - 250) / 2, 180, 250, View.Bounds.Height - 320);
        }
    }
}

