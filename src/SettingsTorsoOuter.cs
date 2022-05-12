using ModSettings;

namespace ClothingTweaker
{

	internal class ClothingTweakerTorsoOuterSettings : JsonModSettings
	{
		public ClothingTweakerTorsoOuterSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		//Astrid's Jacket
		[Section("Astrid's Jacket")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridJacketWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridJacketWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridJacketWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float astridJacketWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float astridJacketProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 4%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float astridJacketMobility = 4.0f;

		[Name("Weight")]
		[Description("Default is 1.25 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float astridJacketWeight = 1.25f;


		//Bearskin Coat
		[Section("Bearskin Coat")]
		[Name("Warmth")]
		[Description("Default is 6°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float bearskinCoatWarmth = 6.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float bearskinCoatWetWarmth = 5.0f;

		[Name("Windproof")]
		[Description("Default is 5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float bearskinCoatWindproof = 5.0f;

		[Name("Waterproof")]
		[Description("Default is 80%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float bearskinCoatWaterproof = 0.8f;

		[Name("Protection")]
		[Description("Default is 15%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float bearskinCoatProtection = 15.0f;

		[Name("Mobility")]
		[Description("Default is 20%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float bearskinCoatMobility = 20.0f;

		[Name("Weight")]
		[Description("Default is 5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float bearskinCoatWeight = 5.0f;


		//Down Vest
		[Section("Down Vest")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float downVestWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float downVestWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float downVestWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float downVestWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float downVestProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float downVestMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float downVestWeight = 0.5f;


		//Expedition Parka
		[Section("Expedition Parka")]
		[Name("Warmth")]
		[Description("Default is 4°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float expeditionParkaWarmth = 4.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float expeditionParkaWetWarmth = 3.0f;

		[Name("Windproof")]
		[Description("Default is 6°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float expeditionParkaWindproof = 6.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float expeditionParkaWaterproof = 0.50f;

		[Name("Protection")]
		[Description("Default is 6%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float expeditionParkaProtection = 6.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float expeditionParkaMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 1.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float expeditionParkaWeight = 1.5f;


		//Light Shell
		[Section("Light Shell")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float lightShellWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float lightShellWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float lightShellWindproof = 3.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float lightShellWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float lightShellProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 2%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float lightShellMobility = 2.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float lightShellWeight = 1.0f;


		//Mackenzie's Parka
		[Section("Mackenzie's Parka")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesParkaWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesParkaWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesParkaWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float mackenziesParkaWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackenziesParkaProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 4%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackenziesParkaMobility = 4.0f;

		[Name("Weight")]
		[Description("Default is 1.25 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float mackenziesParkaWeight = 1.25f;


		//Mackinaw Jacket
		[Section("Mackinaw Jacket")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackinawJacketWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackinawJacketWetWarmth = 2.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackinawJacketWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float mackinawJacketWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackinawJacketProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackinawJacketMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float mackinawJacketWeight = 1.5f;


		//Mariner's Pea Coat
		[Section("Mariner's Pea Coat")]
		[Name("Warmth")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float marinersPeaCoatWarmth = 3.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float marinersPeaCoatWetWarmth = 2.0f;

		[Name("Windproof")]
		[Description("Default is 4°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float marinersPeaCoatWindproof = 4.0f;

		[Name("Waterproof")]
		[Description("Default is 75%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float marinersPeaCoatWaterproof = 0.75f;

		[Name("Protection")]
		[Description("Default is 7%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float marinersPeaCoatProtection = 7.0f;

		[Name("Mobility")]
		[Description("Default is 6%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float marinersPeaCoatMobility = 6.0f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float marinersPeaCoatWeight = 2.0f;


		//Military Coat
		[Section("Military Coat")]
		[Name("Warmth")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float militaryCoatWarmth = 3.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float militaryCoatWetWarmth = 2.0f;

		[Name("Windproof")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float militaryCoatWindproof = 3.0f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float militaryCoatWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 8%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float militaryCoatProtection = 8.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float militaryCoatMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float militaryCoatWeight = 2.0f;


		//Moose-hide Cloak
		[Section("Moose-hide Cloak")]
		[Name("Warmth")]
		[Description("Default is 3.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float moosehideCloakWarmth = 3.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float moosehideCloakWetWarmth = 3.0f;

		[Name("Windproof")]
		[Description("Default is 4°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float moosehideCloakWindproof = 4.0f;

		[Name("Waterproof")]
		[Description("Default is 90%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float moosehideCloakWaterproof = 0.9f;

		[Name("Protection")]
		[Description("Default is 20%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float moosehideCloakProtection = 20.0f;

		[Name("Mobility")]
		[Description("Default is 10%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float moosehideCloakMobility = 10.0f;

		[Name("Weight")]
		[Description("Default is 4 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float moosehideCloakWeight = 4.0f;


		//Old Fashioned Parka
		[Section("Old Fashioned Parka")]
		[Name("Warmth")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float oldFashionedParkaWarmth = 3.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float oldFashionedParkaWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float oldFashionedParkaWindproof = 3.0f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float oldFashionedParkaWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float oldFashionedParkaProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 7%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float oldFashionedParkaMobility = 7.0f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float oldFashionedParkaWeight = 2.0f;

		//Simple Parka
		[Section("Simple Parka")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float simpleParkaWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float simpleParkaWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float simpleParkaWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float simpleParkaWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float simpleParkaProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 4%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float simpleParkaMobility = 4.0f;

		[Name("Weight")]
		[Description("Default is 1.25 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float simpleParkaWeight = 1.25f;


		//Ski Jacket
		[Section("Ski Jacket")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiJacketWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiJacketWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiJacketWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float skiJacketWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float skiJacketProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 2%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float skiJacketMobility = 2.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float skiJacketWeight = 1.0f;


		//Sport Vest
		[Section("Sport Vest")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sportVestWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sportVestWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sportVestWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 5%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float sportVestWaterproof = 0.05f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float sportVestProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float sportVestMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float sportVestWeight = 0.5f;


		//Urban Parka
		[Section("Urban Parka")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float urbanParkaWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float urbanParkaWetWarmth = 2.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float urbanParkaWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float urbanParkaWaterproof = 0.10f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float urbanParkaProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 2%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float urbanParkaMobility = 2.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float urbanParkaWeight = 1.0f;


		//Windbreaker
		[Section("Windbreaker")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float windbreakerWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float windbreakerWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float windbreakerWindproof = 3.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float windbreakerWaterproof = 0.5f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float windbreakerProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float windbreakerMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float windbreakerWeight = 1.0f;


		//Wolfskin Coat
		[Section("Wolfskin Coat")]
		[Name("Warmth")]
		[Description("Default is 4°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float wolfskinCoatWarmth = 4.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float wolfskinCoatWetWarmth = 3.0f;

		[Name("Windproof")]
		[Description("Default is 4°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float wolfskinCoatWindproof = 4.0f;

		[Name("Waterproof")]
		[Description("Default is 60%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float wolfskinCoatWaterproof = 0.6f;

		[Name("Protection")]
		[Description("Default is 12%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float wolfskinCoatProtection = 12.0f;

		[Name("Mobility")]
		[Description("Default is 15%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float wolfskinCoatMobility = 15.0f;

		[Name("Weight")]
		[Description("Default is 3 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float wolfskinCoatWeight = 3.0f;

		protected override void OnConfirm()
		{
			base.OnConfirm();
			ChangePrefabs();
		}

		internal void ChangePrefabs()
		{
			Patches.ChangePrefabParameters("GEAR_BearSkinCoat",
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatWarmth,
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatWetWarmth,
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatWindproof,
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatWaterproof,
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatProtection,
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatMobility,
											SettingsTorsoOuter.torsoOuterSettings.bearskinCoatWeight);
			Patches.ChangePrefabParameters("GEAR_MooseHideCloak",
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakWarmth,
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakWetWarmth,
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakWindproof,
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakWaterproof,
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakProtection,
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakMobility,
											SettingsTorsoOuter.torsoOuterSettings.moosehideCloakWeight);
			Patches.ChangePrefabParameters("GEAR_WolfSkinCape",
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatWarmth,
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatWetWarmth,
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatWindproof,
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatWaterproof,
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatProtection,
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatMobility,
											SettingsTorsoOuter.torsoOuterSettings.wolfskinCoatWeight);
		}
	}

	internal static class SettingsTorsoOuter
	{
		public static ClothingTweakerTorsoOuterSettings torsoOuterSettings;

		public static void OnLoad()
		{
			torsoOuterSettings = new ClothingTweakerTorsoOuterSettings("ClothingTweakerTorsoOuter");
			torsoOuterSettings.AddToModSettings("Clothing Tweaker: Torso (Outer)");
			torsoOuterSettings.ChangePrefabs();
		}
	}
}