using ModSettings;
using UnityEngine;

namespace ClothingTweaker
{

	internal class ClothingTweakerFeetSettings : JsonModSettings
	{
		public ClothingTweakerFeetSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		//Inner

		//Climbing Socks
		[Section("Climbing Socks")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 11, NumberFormat = "{0:0.##}°C")]
		public float climbingSocksWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float climbingSocksWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float climbingSocksWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 25%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float climbingSocksWaterproof = 0.25f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float climbingSocksProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float climbingSocksMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float climbingSocksWeight = 0.25f;


		//Sports Socks
		[Section("Sports Socks")]
		[Name("Warmth")]
		[Description("Default is 0.25°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sportsSocksWarmth = 0.25f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sportsSocksWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float sportsSocksWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float sportsSocksWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float sportsSocksProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float sportsSocksMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.1 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float sportsSocksWeight = 0.1f;


		//Wool Socks
		[Section("Wool Socks")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolSocksWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolSocksWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolSocksWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float woolSocksWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolSocksProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolSocksMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float woolSocksWeight = 0.25f;



		//Outer

		//Astrid's Boots
		[Section("Astrid's Boots")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridBootsWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridBootsWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float astridBootsWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float astridBootsWaterproof = 0.30f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float astridBootsProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float astridBootsMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float astridBootsWeight = 1.0f;


		//Combat Boots
		[Section("Combat Boots")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float combatBootsWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float combatBootsWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float combatBootsWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float combatBootsWaterproof = 0.20f;

		[Name("Protection")]
		[Description("Default is 10%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float combatBootsProtection = 10.0f;

		[Name("Mobility")]
		[Description("Default is 7%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float combatBootsMobility = 7.0f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float combatBootsWeight = 2.0f;


		//Deerskin Boots
		[Section("Deerskin Boots")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float deerskinBootsWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float deerskinBootsWetWarmth = 2.0f;

		[Name("windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float deerskinBootsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float deerskinBootsWaterproof = 0.5f;

		[Name("Protection")]
		[Description("Default is 7%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float deerskinBootsProtection = 7.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float deerskinBootsMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float deerskinBootsWeight = 2.0f;


		//Insulated Boots
		[Section("Insulated Boots")]
		[Name("Warmth")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float insulatedBootsWarmth = 3.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float insulatedBootsWetWarmth = 2.5f;

		[Name("windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float insulatedBootsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float insulatedBootsWaterproof = 0.5f;

		[Name("Protection")]
		[Description("Default is 4%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float insulatedBootsProtection = 4.0f;

		[Name("Mobility")]
		[Description("Default is 12%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float insulatedBootsMobility = 12.0f;

		[Name("Weight")]
		[Description("Default is 1.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float insulatedBootsWeight = 1.5f;


		//Leather Shoes
		[Section("Leather Shoes")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float leatherShoesWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float leatherShoesWetWarmth = 0.0f;

		[Name("windproof")]
		[Description("Default is 0.0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float leatherShoesWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 10%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float leatherShoesWaterproof = 0.1f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float leatherShoesProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float leatherShoesMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float leatherShoesWeight = 0.5f;


		//Mackenzie's Boots
		[Section("Mackenzie's Boots")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesBootsWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesBootsWetWarmth = 0.5f;

		[Name("windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mackenziesBootsWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float mackenziesBootsWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mackenziesBootsProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mackenziesBootsMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float mackenziesBootsWeight = 1.0f;


		//Mountaineering Boots
		[Section("Mountaineering Boots")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mountaineeringBootsWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mountaineeringBootsWetWarmth = 2.0f;

		[Name("windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mountaineeringBootsWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float mountaineeringBootsWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mountaineeringBootsProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mountaineeringBootsMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float mountaineeringBootsWeight = 1.0f;


		//Mukluks
		[Section("Mukluks")]
		[Name("Warmth")]
		[Description("Default is 2.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mukluksWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mukluksWetWarmth = 2.0f;

		[Name("windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float mukluksWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 40%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float mukluksWaterproof = 0.4f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float mukluksProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float mukluksMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float mukluksWeight = 1.5f;


		//Running Shoes
		[Section("Running Shoes")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float runningShoesWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float runningShoesWetWarmth = 0.0f;

		[Name("windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float runningShoesWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float runningShoesWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float runningShoesProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float runningShoesMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float runningShoesWeight = 0.5f;


		//Ski Boots
		[Section("Ski Boots")]
		[Name("Warmth")]
		[Description("Default is 3°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiBootsWarmth = 3.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiBootsWetWarmth = 2.0f;

		[Name("windproof")]
		[Description("Default is 4°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiBootsWindproof = 4.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float skiBootsWaterproof = 0.30f;

		[Name("Protection")]
		[Description("Default is 12%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float skiBootsProtection = 12.0f;

		[Name("Mobility")]
		[Description("Default is 20%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float skiBootsMobility = 20.0f;

		[Name("Weight")]
		[Description("Default is 4 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float skiBootsWeight = 4.0f;


		//Trail Boots
		[Section("Trail Boots")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float trailBootsWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float trailBootsWetWarmth = 0.5f;

		[Name("windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float trailBootsWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float trailBootsWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float trailBootsProtection = 5.0f;

		[Name("Mobility")]
		[Description("Default is 3%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float trailBootsMobility = 3.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float trailBootsWeight = 1.0f;


		//Work Boots
		[Section("Work Boots")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workBootsWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workBootsWetWarmth = 1.0f;

		[Name("windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float workBootsWindproof = 1.0f;

		[Name("Waterproof")]
		[Description("Default is 5%")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float workBootsWaterproof = 0.05f;

		[Name("Protection")]
		[Description("Default is 7%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float workBootsProtection = 7.0f;

		[Name("Mobility")]
		[Description("Default is 10%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float workBootsMobility = 10.0f;

		[Name("Weight")]
		[Description("Default is 1.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float workBootsWeight = 1.5f;

		protected override void OnConfirm()
		{
			base.OnConfirm();
			ChangePrefabs();
		}

		internal void ChangePrefabs()
		{
			Patches.ChangePrefabParameters("GEAR_DeerSkinBoots",
											SettingsFeet.feetSettings.deerskinBootsWarmth,
											SettingsFeet.feetSettings.deerskinBootsWetWarmth,
											SettingsFeet.feetSettings.deerskinBootsWindproof,
											SettingsFeet.feetSettings.deerskinBootsWaterproof,
											SettingsFeet.feetSettings.deerskinBootsProtection,
											SettingsFeet.feetSettings.deerskinBootsMobility,
											SettingsFeet.feetSettings.deerskinBootsWeight);
		}
	}

	internal static class SettingsFeet
	{
		public static ClothingTweakerFeetSettings feetSettings;

		public static void OnLoad()
		{
			feetSettings = new ClothingTweakerFeetSettings("ClothingTweakerFeet");
			feetSettings.AddToModSettings("Clothing Tweaker: Feet");
			feetSettings.ChangePrefabs();
		}
	}
}