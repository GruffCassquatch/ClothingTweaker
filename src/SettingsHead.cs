using ModSettings;

namespace ClothingTweaker
{

	internal class ClothingTweakerHeadSettings : JsonModSettings
	{
		public ClothingTweakerHeadSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		//Astrid's Toque
		[Section("Astrid's Toque")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridToqueWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.75°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridToqueWetWarmth = 0.75f;

		[Name("Windproof")]
		[Description("Default is 0.75°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridToqueWindproof = 0.75f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float astridToqueWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float astridToqueProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float astridToqueMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.15 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float astridToqueWeight = 0.15f;


		//Balaclava
		[Section("Balaclava")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float balaclavaWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float balaclavaWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float balaclavaWindproof = 1.5f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float balaclavaWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float balaclavaProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float balaclavaMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.15 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float balaclavaWeight = 0.15f;


		//Baseball Cap
		[Section("Baseball Cap")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float baseballCapWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float baseballCapWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float baseballCapWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float baseballCapWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float baseballCapProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float baseballCapMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float baseballCapWeight = 0.1f;


		//Cotton Scarf
		[Section("Cotton Scarf")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cottonScarfWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cottonScarfWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cottonScarfWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 5%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float cottonScarfWaterproof = 0.05f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float cottonScarfProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float cottonScarfMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float cottonScarfWeight = 0.1f;


		//Cotton Toque
		[Section("Cotton Toque")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cottonToqueWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cottonToqueWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cottonToqueWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float cottonToqueWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float cottonToqueProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float cottonToqueMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float cottonToqueWeight = 0.1f;


		//Fleece Cowl
		[Section("Fleece Cowl")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fleeceCowlWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fleeceCowlWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float fleeceCowlWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float fleeceCowlWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float fleeceCowlProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float fleeceCowlMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float fleeceCowlWeight = 0.25f;


		//Long Wool Scarf
		[Section("Long Wool Scarf")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float longWoolScarfWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float longWoolScarfWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float longWoolScarfWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float longWoolScarfWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float longWoolScarfProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float longWoolScarfMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float longWoolScarfWeight = 0.25f;


		//Mackenzie's Toque
		[Section("Mackenzie's Toque")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesToqueWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.75°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesToqueWetWarmth = 0.75f;

		[Name("Windproof")]
		[Description("Default is 0.75°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesToqueWindproof = 0.75f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float mackenziesToqueWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackenziesToqueProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackenziesToqueMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.15 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float mackenziesToqueWeight = 0.15f;


		//Rabbitskin Hat
		[Section("Rabbitskin Hat")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float rabbitskinHatWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float rabbitskinHatWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float rabbitskinHatWindproof = 1.5f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float rabbitskinHatWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 4%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float rabbitskinHatProtection = 4.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float rabbitskinHatMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.35 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float rabbitskinHatWeight = 0.35f;


		//Wool Scarf
		[Section("Wool Scarf")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolScarfWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolScarfWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolScarfWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float woolScarfWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolScarfProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolScarfMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float woolScarfWeight = 0.1f;


		//Wool Toque
		[Section("Wool Toque")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolToqueWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolToqueWetWarmth = 1f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolToqueWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float woolToqueWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolToqueProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolToqueMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float woolToqueWeight = 0.25f;

		protected override void OnConfirm()
		{
			base.OnConfirm();
			ChangePrefabs();
		}

		internal void ChangePrefabs()
		{
			if (SettingsMain.mainSettings.modFunction)
			{
				Patches.ChangePrefabParameters("GEAR_RabbitskinHat",
											SettingsHead.headSettings.rabbitskinHatWarmth,
											SettingsHead.headSettings.rabbitskinHatWetWarmth,
											SettingsHead.headSettings.rabbitskinHatWindproof,
											SettingsHead.headSettings.rabbitskinHatWaterproof,
											SettingsHead.headSettings.rabbitskinHatProtection,
											SettingsHead.headSettings.rabbitskinHatMobility,
											SettingsHead.headSettings.rabbitskinHatWeight);
			}
		}
	}

	internal static class SettingsHead
	{
		public static ClothingTweakerHeadSettings headSettings;

		public static void OnLoad()
		{
			if (SettingsMain.mainSettings.showHead != ShowHideDisable.Disable)
			{
				headSettings = new ClothingTweakerHeadSettings("ClothingTweakerHead");
				if (SettingsMain.mainSettings.showHead == ShowHideDisable.Show) headSettings.AddToModSettings("Clothing Tweaker: Head");
				headSettings.ChangePrefabs();
			}
		}
	}
}
