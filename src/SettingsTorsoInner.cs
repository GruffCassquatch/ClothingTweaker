using ModSettings;

namespace ClothingTweaker
{

	internal class ClothingTweakerTorsoInnerSettings : JsonModSettings
	{
		public ClothingTweakerTorsoInnerSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		//Astrid's Sweater
		[Section("Astrid's Sweater")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridSweaterWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridSweaterWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridSweaterWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float astridSweaterWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float astridSweaterProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float astridSweaterMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float astridSweaterWeight = 0.25f;


		//Cowichan Sweater
		[Section("Cowichan Sweater")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cowichanSweaterWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cowichanSweaterWetWarmth = 2.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cowichanSweaterWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float cowichanSweaterWaterproof = 0.5f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float cowichanSweaterProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 2%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float cowichanSweaterMobility = 2.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 2f, 41, NumberFormat = "{0:0.##} kg")]
		public float cowichanSweaterWeight = 1.0f;


		//Dress Shirt
		[Section("Dress Shirt")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float dressShirtWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float dressShirtWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float dressShirtWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float dressShirtWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float dressShirtProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float dressShirtMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float dressShirtWeight = 0.25f;


		//Fisherman's Sweater
		[Section("Fisherman's Sweater")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fishermansSweaterWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fishermansSweaterWetWarmth = 2.0f;

		[Name("Windproof")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fishermansSweaterWindproof = 1.5f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float fishermansSweaterWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float fishermansSweaterProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float fishermansSweaterMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float fishermansSweaterWeight = 0.5f;


		//Hoodie
		[Section("Hoodie")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float hoodieWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float hoodieWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float hoodieWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float hoodieWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float hoodieProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float hoodieMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float hoodieWeight = 0.25f;


		//Mackenzie's Shirt
		[Section("Mackenzie's Shirt")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesShirtWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesShirtWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesShirtWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float mackenziesShirtWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackenziesShirtProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackenziesShirtMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float mackenziesShirtWeight = 0.25f;


		//Mackenzie's Sweater
		[Section("Mackenzie's Sweater")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesSweaterWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesSweaterWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesSweaterWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float mackenziesSweaterWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackenziesSweaterProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackenziesSweaterMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float mackenziesSweaterWeight = 0.25f;


		//Plaid Shirt
		[Section("Plaid Shirt")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float plaidShirtWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float plaidShirtWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float plaidShirtWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float plaidShirtWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float plaidShirtProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float plaidShirtMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float plaidShirtWeight = 0.25f;


		//Sweatshirt
		[Section("Sweatshirt")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sweatshirtWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sweatshirtWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sweatshirtWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float sweatshirtWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float sweatshirtProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float sweatshirtMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float sweatshirtWeight = 0.25f;


		//Thick Wool Sweater
		[Section("Thick Wool Sweater")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thickWoolSweaterWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thickWoolSweaterWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thickWoolSweaterWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float thickWoolSweaterWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float thickWoolSweaterProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float thickWoolSweaterMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float thickWoolSweaterWeight = 0.5f;


		//Thin Wool Sweater
		[Section("Thin Wool Sweater")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thinWoolSweaterWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.75°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thinWoolSweaterWetWarmth = 0.75f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thinWoolSweaterWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float thinWoolSweaterWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float thinWoolSweaterProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float thinWoolSweaterMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float thinWoolSweaterWeight = 0.25f;


		//T-shirt
		[Section("T-Shirt")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float tshirtWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float tshirtWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float tshirtWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float tshirtWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float tshirtProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float tshirtMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float tshirtWeight = 0.25f;


		//Wool Shirt
		[Section("Wool Shirt")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolShirtWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolShirtWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolShirtWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float woolShirtWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolShirtProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolShirtMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float woolShirtWeight = 0.25f;
	}

	internal static class SettingsTorsoInner
	{
		public static ClothingTweakerTorsoInnerSettings torsoInnerSettings;

		public static void OnLoad()
		{
			torsoInnerSettings = new ClothingTweakerTorsoInnerSettings("ClothingTweakerTorsoInner");
			torsoInnerSettings.AddToModSettings("Clothing Tweaker: Torso (Inner)");
		}
	}
}