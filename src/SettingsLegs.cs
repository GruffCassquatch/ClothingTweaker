using ModSettings;

namespace ClothingTweaker
{

	internal class ClothingTweakerLegsSettings : JsonModSettings
	{
		public ClothingTweakerLegsSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		//Thermal Underwear
		[Section("Thermal Underwear")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thermalUnderwearWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thermalUnderwearWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float thermalUnderwearWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float thermalUnderwearWaterproof = 0.20f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float thermalUnderwearProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float thermalUnderwearMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float thermalUnderwearWeight = 0.25f;


		//Wool Longjohns
		[Section("Wool Longjohns")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolLongjohnsWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolLongjohnsWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolLongjohnsWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 35%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float woolLongjohnsWaterproof = 0.35f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolLongjohnsProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolLongjohnsMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float woolLongjohnsWeight = 0.5f;


		//Outer

		//Astrid's Jeans
		[Section("Astrid's Jeans")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridJeansWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridJeansWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridJeansWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float astridJeansWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float astridJeansProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float astridJeansMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float astridJeansWeight = 0.5f;


		//Cargo Pants
		[Section("Cargo Pants")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cargoPantsWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cargoPantsWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cargoPantsWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float cargoPantsWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float cargoPantsProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float cargoPantsMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.75 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float cargoPantsWeight = 0.75f;


		//Combat Pants
		[Section("Combat Pants")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float combatPantsWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float combatPantsWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float combatPantsWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float combatPantsWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 7%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float combatPantsProtection = 7.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float combatPantsMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.75 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float combatPantsWeight = 0.75f;


		//Deerskin Pants
		[Section("Deerskin Pants")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float deerskinPantsWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float deerskinPantsWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float deerskinPantsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 60%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float deerskinPantsWaterproof = 0.6f;

		[Name("Protection")]
		[Description("Default is 10%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float deerskinPantsProtection = 10.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float deerskinPantsMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float deerskinPantsWeight = 2.0f;


		//Jeans
		[Section("Jeans")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float jeansWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float jeansWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float jeansWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float jeansWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float jeansProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float jeansMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float jeansWeight = 0.5f;


		//Mackenzie's Pants
		[Section("Mackenzie's Pants")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesPantsWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesPantsWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesPantsWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float mackenziesPantsWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackenziesPantsProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackenziesPantsMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float mackenziesPantsWeight = 0.5f;


		//Snow Pants
		[Section("Snow Pants")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float snowPantsWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float snowPantsWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float snowPantsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float snowPantsWaterproof = 0.50f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float snowPantsProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float snowPantsMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float snowPantsWeight = 1.0f;


		//Work Pants
		[Section("Work Pants")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workPantsWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workPantsWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workPantsWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float workPantsWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 8%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float workPantsProtection = 8.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float workPantsMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1.5 kg")]
		[Slider(0f, 2.5f, 51, NumberFormat = "{0:0.##} kg")]
		public float workPantsWeight = 1.5f;

		protected override void OnConfirm()
		{
			base.OnConfirm();
			ChangePrefabs();
		}

		internal void ChangePrefabs()
		{
			Patches.ChangePrefabParameters("GEAR_DeerSkinPants",
											SettingsLegs.legsSettings.deerskinPantsWarmth,
											SettingsLegs.legsSettings.deerskinPantsWetWarmth,
											SettingsLegs.legsSettings.deerskinPantsWindproof,
											SettingsLegs.legsSettings.deerskinPantsWaterproof,
											SettingsLegs.legsSettings.deerskinPantsProtection,
											SettingsLegs.legsSettings.deerskinPantsMobility,
											SettingsLegs.legsSettings.deerskinPantsWeight);
		}
	}

	internal static class SettingsLegs
	{
		public static ClothingTweakerLegsSettings legsSettings;

		public static void OnLoad()
		{
			legsSettings = new ClothingTweakerLegsSettings("ClothingTweakerLegs");
			legsSettings.AddToModSettings("Clothing Tweaker: Legs");
			legsSettings.ChangePrefabs();
		}
	}
}