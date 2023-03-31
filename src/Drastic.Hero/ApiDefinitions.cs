using CoreAnimation;
using Foundation;
using ObjCRuntime;
using UIKit;
using CoreGraphics;

namespace Hero
{
	// @interface Hero_Swift_261 (CALayer)
	[Category]
	[BaseType (typeof(CALayer))]
	interface CALayer_Hero_Swift_261
	{
		// -(void)hero_addWithAnim:(CAAnimation * _Nonnull)anim forKey:(NSString * _Nullable)forKey;
		[Export ("hero_addWithAnim:forKey:")]
		void Hero_addWithAnim (CAAnimation anim, [NullAllowed] string forKey);
	}

	// @interface Hero : NSObject
	[BaseType (typeof(NSObject))]
	interface Hero
	{
	}

	// @interface HeroPlugin : NSObject
	[BaseType (typeof(NSObject))]
	interface HeroPlugin
	{
	}

	// @interface HeroDebugPlugin : HeroPlugin
	[BaseType (typeof(HeroPlugin))]
	interface HeroDebugPlugin
	{
	}

	// @interface HeroDebugView : UIView
	[BaseType (typeof(UIView))]
	interface HeroDebugView
	{
		// // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// // -(void)layoutSubviews;
		// [Export ("layoutSubviews")]
		// void LayoutSubviews ();

		// -(void)pan;
		[Export ("pan")]
		void Pan ();

		// -(void)pinch;
		[Export ("pinch")]
		void Pinch ();

		// -(void)onDone;
		[Export ("onDone")]
		void OnDone ();

		// -(void)onPerspective;
		[Export ("onPerspective")]
		void OnPerspective ();

		// -(void)onDisplayArcCurve;
		[Export ("onDisplayArcCurve")]
		void OnDisplayArcCurve ();

		// -(void)onSlide;
		[Export ("onSlide")]
		void OnSlide ();
	}

	// // @interface Hero_Swift_315 (HeroDebugView) <UIGestureRecognizerDelegate>
	// // [Category]
	// [BaseType (typeof(HeroDebugView))]
	// interface HeroDebugView_Hero_Swift_315 : IUIGestureRecognizerDelegate
	// {
	// 	// -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer __attribute__((warn_unused_result("")));
	// 	[Export ("gestureRecognizerShouldBegin:")]
	// 	bool GestureRecognizerShouldBegin (UIGestureRecognizer gestureRecognizer);
	// }

	// @interface HeroTransition : NSObject
	[BaseType (typeof(NSObject))]
	interface HeroTransition
	{
	}

	// @interface Hero_Swift_336 (HeroTransition) <UIViewControllerInteractiveTransitioning>
	// [Category]
	[BaseType (typeof(HeroTransition))]
	interface HeroTransition_Hero_Swift_336 : IUIViewControllerInteractiveTransitioning
	{
		// @property (readonly, nonatomic) BOOL wantsInteractiveStart;
		[Export ("wantsInteractiveStart")]
		bool WantsInteractiveStart { get; }

		// // -(void)startInteractiveTransition:(id<UIViewControllerContextTransitioning> _Nonnull)transitionContext;
		// [Export ("startInteractiveTransition:")]
		// void StartInteractiveTransition (UIViewControllerContextTransitioning transitionContext);
	}

	// @interface Hero_Swift_345 (HeroTransition) <UITabBarControllerDelegate>
	[BaseType (typeof(HeroTransition))]
	interface HeroTransition_Hero_Swift_345 : IUITabBarControllerDelegate
	{
		// -(BOOL)tabBarController:(UITabBarController * _Nonnull)tabBarController shouldSelectViewController:(UIViewController * _Nonnull)viewController __attribute__((warn_unused_result("")));
		[Export ("tabBarController:shouldSelectViewController:")]
		bool TabBarController (UITabBarController tabBarController, UIViewController viewController);

		// -(id<UIViewControllerInteractiveTransitioning> _Nullable)tabBarController:(UITabBarController * _Nonnull)tabBarController interactionControllerForAnimationController:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animationController __attribute__((warn_unused_result("")));
		[Export ("tabBarController:interactionControllerForAnimationController:")]
		[return: NullAllowed]
		UIViewControllerInteractiveTransitioning TabBarController (UITabBarController tabBarController, UIViewControllerAnimatedTransitioning animationController);

		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)tabBarController:(UITabBarController * _Nonnull)tabBarController animationControllerForTransitionFromViewController:(UIViewController * _Nonnull)fromVC toViewController:(UIViewController * _Nonnull)toVC __attribute__((warn_unused_result("")));
		[Export ("tabBarController:animationControllerForTransitionFromViewController:toViewController:")]
		[return: NullAllowed]
		UIViewControllerAnimatedTransitioning TabBarController (UITabBarController tabBarController, UIViewController fromVC, UIViewController toVC);
	}

	// // @interface Hero_Swift_352 (HeroTransition) <UIViewControllerAnimatedTransitioning>
	// [Category]
	[BaseType (typeof(HeroTransition))]
	interface HeroTransition_Hero_Swift_352 : IUIViewControllerAnimatedTransitioning
	{
		// // -(void)animateTransition:(id<UIViewControllerContextTransitioning> _Nonnull)context;
		// [Export ("animateTransition:")]
		// void AnimateTransition (UIViewControllerContextTransitioning context);

		// // -(NSTimeInterval)transitionDuration:(id<UIViewControllerContextTransitioning> _Nullable)transitionContext __attribute__((warn_unused_result("")));
		// // [Export ("transitionDuration:")]
		// // double TransitionDuration ([NullAllowed] UIViewControllerContextTransitioning transitionContext);

		// // -(void)animationEnded:(BOOL)transitionCompleted;
		// [Export ("animationEnded:")]
		// void AnimationEnded (bool transitionCompleted);
	}

	// // @interface Hero_Swift_360 (HeroTransition) <UINavigationControllerDelegate>
	// [Category]
	[BaseType (typeof(HeroTransition))]
	interface HeroTransition_Hero_Swift_360 : IUINavigationControllerDelegate
	{
		// // -(void)navigationController:(UINavigationController * _Nonnull)navigationController willShowViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
		// [Export ("navigationController:willShowViewController:animated:")]
		// void NavigationController (UINavigationController navigationController, UIViewController willShowViewController, bool animated);

		// // -(void)navigationController:(UINavigationController * _Nonnull)navigationController didShowViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
		// [Export ("navigationController:didShowViewController:animated:")]
		// void NavigationController (UINavigationController navigationController, UIViewController didShowViewController, bool animated);

		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController animationControllerForOperation:(UINavigationControllerOperation)operation fromViewController:(UIViewController * _Nonnull)fromVC toViewController:(UIViewController * _Nonnull)toVC __attribute__((warn_unused_result("")));
		[Export ("navigationController:animationControllerForOperation:fromViewController:toViewController:")]
		[return: NullAllowed]
		UIViewControllerAnimatedTransitioning NavigationController (UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromVC, UIViewController toVC);

		// -(id<UIViewControllerInteractiveTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController interactionControllerForAnimationController:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animationController __attribute__((warn_unused_result("")));
		[Export ("navigationController:interactionControllerForAnimationController:")]
		[return: NullAllowed]
		UIViewControllerInteractiveTransitioning NavigationController (UINavigationController navigationController, UIViewControllerAnimatedTransitioning animationController);
	}

	// // @interface Hero_Swift_369 (HeroTransition) <UIViewControllerTransitioningDelegate>
	// [Category]
	[BaseType (typeof(HeroTransition))]
	interface HeroTransition_Hero_Swift_369 : IUIViewControllerTransitioningDelegate
	{
		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForPresentedController:(UIViewController * _Nonnull)presented presentingController:(UIViewController * _Nonnull)presenting sourceController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
		[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
		[return: NullAllowed]
		UIViewControllerAnimatedTransitioning AnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source);

		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForDismissedController:(UIViewController * _Nonnull)dismissed __attribute__((warn_unused_result("")));
		[Export ("animationControllerForDismissedController:")]
		[return: NullAllowed]
		UIViewControllerAnimatedTransitioning AnimationControllerForDismissedController (UIViewController dismissed);

		// -(id<UIViewControllerInteractiveTransitioning> _Nullable)interactionControllerForDismissal:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animator __attribute__((warn_unused_result("")));
		[Export ("interactionControllerForDismissal:")]
		[return: NullAllowed]
		UIViewControllerInteractiveTransitioning InteractionControllerForDismissal (UIViewControllerAnimatedTransitioning animator);

		// -(id<UIViewControllerInteractiveTransitioning> _Nullable)interactionControllerForPresentation:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animator __attribute__((warn_unused_result("")));
		[Export ("interactionControllerForPresentation:")]
		[return: NullAllowed]
		UIViewControllerInteractiveTransitioning InteractionControllerForPresentation (UIViewControllerAnimatedTransitioning animator);
	}

	// @interface HeroViewControllerConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface HeroViewControllerConfig
	{
	}

	// @protocol HeroViewControllerDelegate
	[Protocol, Model]
	[BaseType(typeof(UIViewController))]
	interface HeroViewControllerDelegate
	{
		// @optional -(void)heroWillStartAnimatingFromViewController:(UIViewController * _Nonnull)viewController;
		[Export ("heroWillStartAnimatingFromViewController:")]
		void HeroWillStartAnimatingFromViewController (UIViewController viewController);

		// @optional -(void)heroDidEndAnimatingFromViewController:(UIViewController * _Nonnull)viewController;
		[Export ("heroDidEndAnimatingFromViewController:")]
		void HeroDidEndAnimatingFromViewController (UIViewController viewController);

		// @optional -(void)heroDidCancelAnimatingFromViewController:(UIViewController * _Nonnull)viewController;
		[Export ("heroDidCancelAnimatingFromViewController:")]
		void HeroDidCancelAnimatingFromViewController (UIViewController viewController);

		// @optional -(void)heroWillStartTransition;
		[Export ("heroWillStartTransition")]
		void HeroWillStartTransition ();

		// @optional -(void)heroDidEndTransition;
		[Export ("heroDidEndTransition")]
		void HeroDidEndTransition ();

		// @optional -(void)heroDidCancelTransition;
		[Export ("heroDidCancelTransition")]
		void HeroDidCancelTransition ();

		// @optional -(void)heroWillStartAnimatingToViewController:(UIViewController * _Nonnull)viewController;
		[Export ("heroWillStartAnimatingToViewController:")]
		void HeroWillStartAnimatingToViewController (UIViewController viewController);

		// @optional -(void)heroDidEndAnimatingToViewController:(UIViewController * _Nonnull)viewController;
		[Export ("heroDidEndAnimatingToViewController:")]
		void HeroDidEndAnimatingToViewController (UIViewController viewController);

		// @optional -(void)heroDidCancelAnimatingToViewController:(UIViewController * _Nonnull)viewController;
		[Export ("heroDidCancelAnimatingToViewController:")]
		void HeroDidCancelAnimatingToViewController (UIViewController viewController);
	}

	// @interface SnapshotWrapperView : UIView
	[BaseType (typeof(UIView))]
	interface SnapshotWrapperView
	{
		// // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// // -(void)layoutSubviews;
		// [Export ("layoutSubviews")]
		// void LayoutSubviews ();
	}


	// @interface Hero_Swift_494 (UINavigationController)
	[Category]
	[BaseType(typeof(UINavigationController))]
	interface UINavigationController_Hero_Swift_494
	{
		// @property (copy, nonatomic) NSString * _Nullable heroNavigationAnimationTypeString;

		[Export("heroNavigationAnimationTypeString")]
		string HeroNavigationAnimationTypeString();

		[Export("setHeroNavigationAnimationTypeString:")]
		void SetHeroNavigationAnimationTypeString(string modifier);
	}

	// @interface Hero_Swift_499 (UITabBarController)
	[Category]
	[BaseType(typeof(UITabBarController))]
	interface UITabBarController_Hero_Swift_499
	{
		// @property (copy, nonatomic) NSString * _Nullable heroTabBarAnimationTypeString;
		[Export("heroTabBarAnimationTypeString")]
		string HeroTabBarAnimationTypeString();

		[Export("setHeroTabBarAnimationTypeString:")]
		void SetHeroTabBarAnimationTypeString(string modifier);

	}

	// @interface Hero_Swift_420 (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_Hero_Swift_420
	{
		// @property (copy, nonatomic) NSString * _Nullable heroID;
		[Export("heroID")]
		string HeroID();

		// @property (nonatomic) BOOL isHeroEnabled;
		[Export ("isHeroEnabled")]
		bool IsHeroEnabled();

				// @property (nonatomic) BOOL isHeroEnabled;
		[Export("setIsHeroEnabled:")]
		void SetHeroEnabled(bool value);

		// @property (nonatomic) BOOL isHeroEnabledForSubviews;
		[Export ("isHeroEnabledForSubviews")]
		bool IsHeroEnabledForSubviews();

		[Export("setHeroID:")]
		void SetHeroID(string id);

		// @property (copy, nonatomic) NSString * _Nullable heroModifierString;
		[Export("heroModifierString")]
		string HeroModifierString();

		[Export("setHeroModifierString:")]
		void SetHeroModifierString(string modifier);
	}

	// @interface Hero_Swift_436 (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_Hero_Swift_436
	{
		// @property (copy, nonatomic) NSString * _Nullable heroModalAnimationTypeString;
		[Export("heroModalAnimationTypeString")]
		string HeroModalAnimationTypeString();

		[Export("setHeroModalAnimationTypeString:")]
		void SetHeroModalAnimationTypeString(string modifier);

				// -(void)hero_dismissViewController __attribute__((ibaction));
		[Export("hero_dismissViewController")]
		void Hero_dismissViewController();

// -(void)hero_unwindToRootViewController __attribute__((ibaction));
		[Export("hero_unwindToRootViewController")]
		void Hero_unwindToRootViewController();

		// -(void)hero_unwindToViewController:(UIViewController * _Nonnull)toViewController;
		[Export("hero_unwindToViewController:")]
		void Hero_unwindToViewController(UIViewController toViewController);

		// -(void)hero_unwindToViewControllerWithSelector:(SEL _Nonnull)withSelector;
		[Export("hero_unwindToViewControllerWithSelector:")]
		void Hero_unwindToViewControllerWithSelector(Selector withSelector);

		// -(void)hero_unwindToViewControllerWithClass:(Class _Nonnull)withClass;
		[Export("hero_unwindToViewControllerWithClass:")]
		void Hero_unwindToViewControllerWithClass(Class withClass);

		// // -(void)hero_unwindToViewControllerWithMatchBlock:(BOOL (^ _Nonnull)(UIViewController * _Nonnull))withMatchBlock;
		// [Export("hero_unwindToViewControllerWithMatchBlock:")]
		// void Hero_unwindToViewControllerWithMatchBlock(Func<UIViewController, bool> withMatchBlock);

		// -(void)hero_replaceViewControllerWith:(UIViewController * _Nonnull)next;
		[Export("hero_replaceViewControllerWith:")]
		void Hero_replaceViewControllerWith(UIViewController next);

		// -(void)hero_presentOnTopWithViewController:(UIViewController * _Nonnull)viewController frame:(CGRect)frame;
		[Export("hero_presentOnTopWithViewController:frame:")]
		void Hero_presentOnTopWithViewController(UIViewController viewController, CGRect frame); 

				// -(void)ht_dismiss:(UIView * _Nonnull)sender __attribute__((ibaction));
		[Export("ht_dismiss:")]
		void Ht_dismiss(UIView sender);


		// @property (nonatomic) BOOL isHeroEnabled;
		[Export("isHeroEnabled")]
		bool IsHeroEnabled();

		// @property (nonatomic) BOOL isHeroEnabled;
		[Export("setIsHeroEnabled:")]
		void SetHeroEnabled(bool value);
	}

	// [Static]
	// [Verify (ConstantsInterfaceAssociation)]
	// partial interface Constants
	// {
	// 	// extern double HeroVersionNumber;
	// 	[Field ("HeroVersionNumber", "__Internal")]
	// 	double HeroVersionNumber { get; }

	// 	// extern const unsigned char[] HeroVersionString;
	// 	[Field ("HeroVersionString", "__Internal")]
	// 	byte[] HeroVersionString { get; }
	// }
}
