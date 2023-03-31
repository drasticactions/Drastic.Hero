[![NuGet Version](https://img.shields.io/nuget/v/Drastic.Hero.svg)](https://www.nuget.org/packages/Drastic.Hero/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.Hero

Drastic.Hero is a .NET binding of [Hero](https://github.com/HeroTransitions/Hero) for .NET iOS Platforms. It is partially based on an older binding called [Xam.Hero](https://github.com/aloisdeniel/Xam.Hero).

Hero is a library for building iOS view controller transitions. By tagging `UIView` and `UIViewController` elements, you can chain views between UIViewController transitions.

## How To

The same API from the previous binding applies here.

```csharp

using Hero;

public class E1SourceViewController : UIViewController
{
	public override void ViewDidLoad()
	{
		base.ViewDidLoad();

		blackView.Hero().ID = "batman";
		redView.Hero().ID = "ironman";
	}
}
```


```csharp
public class E1DestViewController : UIViewController
{
	public override void ViewDidLoad()
	{
		base.ViewDidLoad();
		
		this.Hero().IsEnabled = true;
			this.Hero().SetModalAnimation(HeroDefaultAnimationType.PageIn, HeroAnimationDirection.Right);
		
		blackView.Hero().ID = "batman";
		redView.Hero().ID = "ironman";
		whiteView.Hero().Modifiers = Modifiers.Fade().Duration(2);
	}
}
```