using ModSettings;
using UnityEngine;

namespace ClothingTweaker
{

	internal class ClothingTweakerAccessoriesSettings : JsonModSettings
	{
		public ClothingTweakerAccessoriesSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}
		private const string CRAMPONS = "GEAR_Crampons";

		//Crampons
		[Section("Crampons")]
		[Name("Warmth")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cramponsWarmth = 0.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cramponsWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float cramponsWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 70%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float cramponsWaterproof = 0.7f;

		[Name("Protection")]
		[Description("Default is 10%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float cramponsProtection = 10.0f;

		[Name("Mobility")]
		[Description("Default is 5%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float cramponsMobility = 5.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float cramponsWeight = 0.5f;


		//Moose-hide Satchel
		[Section("Moose-hide Satchel")]
		[Name("Warmth")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float moosehideSatchelWarmth = 0.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float moosehideSatchelWetWarmth = 0.0f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float moosehideSatchelWindproof = 0.0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float moosehideSatchelWaterproof = 0.0f;

		[Name("Protection")]
		[Description("Default is 0%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float moosehideSatchelProtection = 0.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float moosehideSatchelMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float moosehideSatchelWeight = 0.25f;


		//Wool Ear Wrap
		[Section("Wool Ear Wrap")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolEarWrapWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolEarWrapWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float woolEarWrapWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float woolEarWrapWaterproof = 0.20f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float woolEarWrapProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float woolEarWrapMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:0.##} kg")]
		public float woolEarWrapWeight = 0.25f;

		protected override void OnConfirm()
		{
			base.OnConfirm();
			ChangePrefabs();
		}
		internal void ChangePrefabs()
		{
			Patches.ChangePrefabParameters("GEAR_MooseHideBag",
											SettingsAccessories.accessorySettings.moosehideSatchelWarmth,
											SettingsAccessories.accessorySettings.moosehideSatchelWetWarmth,
											SettingsAccessories.accessorySettings.moosehideSatchelWindproof,
											SettingsAccessories.accessorySettings.moosehideSatchelWaterproof,
											SettingsAccessories.accessorySettings.moosehideSatchelProtection,
											SettingsAccessories.accessorySettings.moosehideSatchelMobility,
											SettingsAccessories.accessorySettings.moosehideSatchelWeight);
		}
	}

	internal static class SettingsAccessories
	{
		public static ClothingTweakerAccessoriesSettings accessorySettings;

		public static void OnLoad()
		{
			accessorySettings = new ClothingTweakerAccessoriesSettings("ClothingTweakerAccessories");
			accessorySettings.AddToModSettings("Clothing Tweaker: Accessories");
			accessorySettings.ChangePrefabs();
		}
	}
}