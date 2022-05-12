using ModSettings;

namespace ClothingTweaker
{

	internal class ClothingTweakerHandsSettings : JsonModSettings
	{
		public ClothingTweakerHandsSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		//Astrid's Gloves
		[Section("Astrid's Gloves")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridGlovesWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridGlovesWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridGlovesWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 5%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float astridGlovesWaterproof = 0.05f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float astridGlovesProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float astridGlovesMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float astridGlovesWeight = 0.1f;


		//Driving Gloves
		[Section("Driving Gloves")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float drivingGlovesWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float drivingGlovesWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float drivingGlovesWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float drivingGlovesWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float drivingGlovesProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float drivingGlovesMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float drivingGlovesWeight = 0.1f;


		//Fleece Mittens
		[Section("Fleece Mittens")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fleeceMittensWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fleeceMittensWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fleeceMittensWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 5%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float fleeceMittensWaterproof = 0.05f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float fleeceMittensProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float fleeceMittensMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float fleeceMittensWeight = 0.1f;


		//Gauntlets
		[Section("Gauntlets")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float gauntletsWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float gauntletsWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float gauntletsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float gauntletsWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 6%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float gauntletsProtection = 6.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float gauntletsMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float gauntletsWeight = 0.1f;


		//Rabbitskin Mitts
		[Section("Rabbitskin Mitts")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float rabbitskinMittsWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float rabbitskinMittsWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float rabbitskinMittsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float rabbitskinMittsWaterproof = 0.5f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float rabbitskinMittsProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float rabbitskinMittsMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float rabbitskinMittsWeight = 1.0f;


		//Ski Gloves
		[Section("Ski Gloves")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiGlovesWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiGlovesWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiGlovesWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float skiGlovesWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float skiGlovesProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float skiGlovesMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float skiGlovesWeight = 0.5f;


		//Wool Mittens
		[Section("Wool Mittens")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolMittensWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.75°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolMittensWetWarmth = 0.75f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolMittensWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float woolMittensWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolMittensProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolMittensMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float woolMittensWeight = 0.1f;


		//Work Gloves
		[Section("Work Gloves")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workGlovesWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workGlovesWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workGlovesWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float workGlovesWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 4%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float workGlovesProtection = 4.0f;

		[Name("Mobility")]
		[Description("Default is 2%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float workGlovesMobility = 2.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float workGlovesWeight = 0.25f;
		
		protected override void OnConfirm()
		{
			base.OnConfirm();
			ChangePrefabs();
		}

		internal void ChangePrefabs()
		{
			Patches.ChangePrefabParameters("GEAR_RabbitSkinMittens",
											SettingsHands.handsSettings.rabbitskinMittsWarmth,
											SettingsHands.handsSettings.rabbitskinMittsWetWarmth,
											SettingsHands.handsSettings.rabbitskinMittsWindproof,
											SettingsHands.handsSettings.rabbitskinMittsWaterproof,
											SettingsHands.handsSettings.rabbitskinMittsProtection,
											SettingsHands.handsSettings.rabbitskinMittsMobility,
											SettingsHands.handsSettings.rabbitskinMittsWeight);
		}
	}

	internal static class SettingsHands
	{
		public static ClothingTweakerHandsSettings handsSettings;

		public static void OnLoad()
		{
			handsSettings = new ClothingTweakerHandsSettings("ClothingTweakerHands");
			handsSettings.AddToModSettings("Clothing Tweaker: Hands");
			handsSettings.ChangePrefabs();
		}
	}
}