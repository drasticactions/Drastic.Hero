using System;
using Hero;

namespace Drastic.HeroSamples
{
    public class BuiltInTransitionExampleViewController1 : ExampleBaseViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.FromRGB(252, 58, 94);
        }

        public override void OnTap()
        {
            var vc2 = new BuiltInTransitionExampleViewController2();

            // this enables Hero
            vc2.SetHeroEnabled(true);

            // this configures the built in animation
            //    vc2.hero.modalAnimationType = .zoom
            //    vc2.hero.modalAnimationType = .pageIn(direction: .left)
            //    vc2.hero.modalAnimationType = .pull(direction: .left)
            //    vc2.hero.modalAnimationType = .autoReverse(presenting: .pageIn(direction: .left))

            vc2.Hero().SetModalAnimation(HeroDefaultAnimationType.Push, HeroAnimationDirection.Left);
            //vc2.HeroModalAnimationType = HeroDefaultAnimationType.SelectBy(presenting: HeroDefaultAnimationType.Pull(direction: HeroDirection.Left), dismissing: HeroDefaultAnimationType.Slide(direction: HeroDirection.Down));

            // lastly, present the view controller like normal
            PresentViewController(vc2, true, null);
        }
    }

    public class BuiltInTransitionExampleViewController2 : ExampleBaseViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.FromRGB(85, 85, 85);
        }
    }
}

