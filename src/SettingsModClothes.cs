using ModSettings;
using System.Reflection;

namespace ClothingTweaker
{

	internal class ClothingTweakerModClothesSettings : JsonModSettings
	{
		public ClothingTweakerModClothesSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}

		//Clothing Pack
		[Section("Mod: Clothing Pack")]
		[Name("Clothing Pack")]
		[Description("Show clothes added by Clothing Pack mod")]
		public bool clothingPack = false;

		//Beanie Cap
		[Section("Beanie Cap")]
		[Name("Warmth")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float beanieCapWarmth = 1.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float beanieCapWetWarmth = 1f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float beanieCapWindproof = 1f;

		[Name("Waterproof")]
		[Description("Default is 60%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float beanieCapWaterproof = 0.6f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float beanieCapProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float beanieCapMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.15 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float beanieCapWeight = 0.15f;


		//Ski Goggles
		[Section("Ski Goggles")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiGogglesWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.25°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiGogglesWetWarmth = 0.25f;

		[Name("Windproof")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiGogglesWindproof = 1f;

		[Name("Waterproof")]
		[Description("Default is 50%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float skiGogglesWaterproof = 0.5f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float skiGogglesProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float skiGogglesMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.2 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float skiGogglesWeight = 0.2f;


		//Ski Mask
		[Section("Ski Mask")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiMaskWarmth = 2f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiMaskWetWarmth = 1.5f;

		[Name("Windproof")]
		[Description("Default is 1.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float skiMaskWindproof = 1.5f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float skiMaskWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float skiMaskProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float skiMaskMobility = 0.0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 0.5f, 11, NumberFormat = "{0:0.##} kg")]
		public float skiMaskWeight = 0.25f;


		// Prison Pack
		[Section("Mod: Prison Pack")]
		[Name("Prison Pack")]
		[Description("Show clothes added by Prison Pack mod")]
		public bool prisonPack = false;

		//Prison Coat
		[Section("Prison Coat")]
		[Name("Warmth")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonCoatWarmth = 2.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonCoatWetWarmth = 1.0f;

		[Name("Windproof")]
		[Description("Default is 2°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonCoatWindproof = 2.0f;

		[Name("Waterproof")]
		[Description("Default is 30%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float prisonCoatWaterproof = 0.3f;

		[Name("Protection")]
		[Description("Default is 3%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float prisonCoatProtection = 3.0f;

		[Name("Mobility")]
		[Description("Default is 4%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float prisonCoatMobility = 4.0f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float prisonCoatWeight = 1f;


		//Prison Pants
		[Section("Prison Pants")]
		[Name("Warmth")]
		[Description("Default is 1°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonPantsWarmth = 1.0f;

		[Name("Warmth When Wet")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonPantsWetWarmth = 0.5f;

		[Name("Windproof")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonPantsWindproof = 0f;

		[Name("Waterproof")]
		[Description("Default is 0%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float prisonPantsWaterproof = 0f;

		[Name("Protection")]
		[Description("Default is 2%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float prisonPantsProtection = 2.0f;

		[Name("Mobility")]
		[Description("Default is 1%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float prisonPantsMobility = 1.0f;

		[Name("Weight")]
		[Description("Default is 0.5 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float prisonPantsWeight = 0.5f;


		//Prison Shirt
		[Section("Prison Shirt")]
		[Name("Warmth")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonShirtWarmth = 0.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 0°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonShirtWetWarmth = 0f;

		[Name("Windproof")]
		[Description("Default is 0.5°C")]
		[Slider(0f, 10f, 41, NumberFormat = "{0:0.##}°C")]
		public float prisonShirtWindproof = 0.5f;

		[Name("Waterproof")]
		[Description("Default is 20%")]
		[Slider(0f, 1f, 21, NumberFormat = "{0:P0}")]
		public float prisonShirtWaterproof = 0.2f;

		[Name("Protection")]
		[Description("Default is 1%")]
		[Slider(0f, 50f, 51, NumberFormat = "{0:F0}%")]
		public float prisonShirtProtection = 1.0f;

		[Name("Mobility")]
		[Description("Default is 0%")]
		[Slider(0f, 25f, 26, NumberFormat = "{0:F0}%")]
		public float prisonShirtMobility = 0f;

		[Name("Weight")]
		[Description("Default is 0.25 kg")]
		[Slider(0f, 5f, 101, NumberFormat = "{0:0.##} kg")]
		public float prisonShirtWeight = 0.25f;


		protected override void OnChange(FieldInfo field, object oldValue, object newValue)
		{
			if (field.Name == nameof(clothingPack) || field.Name == nameof(prisonPack))
			{
				RefreshFields();
			}
		}

		internal void RefreshFields()
		{
			SetFieldVisible(nameof(beanieCapWarmth), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(beanieCapWetWarmth), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(beanieCapWindproof), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(beanieCapWaterproof), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(beanieCapProtection), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(beanieCapMobility), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(beanieCapWeight), SettingsModClothes.modClothesSettings.clothingPack);

			SetFieldVisible(nameof(skiGogglesWarmth), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiGogglesWetWarmth), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiGogglesWindproof), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiGogglesWaterproof), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiGogglesProtection), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiGogglesMobility), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiGogglesWeight), SettingsModClothes.modClothesSettings.clothingPack);

			SetFieldVisible(nameof(skiMaskWarmth), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiMaskWetWarmth), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiMaskWindproof), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiMaskWaterproof), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiMaskProtection), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiMaskMobility), SettingsModClothes.modClothesSettings.clothingPack);
			SetFieldVisible(nameof(skiMaskWeight), SettingsModClothes.modClothesSettings.clothingPack);

			SetFieldVisible(nameof(prisonCoatWarmth), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonCoatWetWarmth), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonCoatWindproof), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonCoatWaterproof), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonCoatProtection), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonCoatMobility), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonCoatWeight), SettingsModClothes.modClothesSettings.prisonPack);

			SetFieldVisible(nameof(prisonPantsWarmth), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonPantsWetWarmth), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonPantsWindproof), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonPantsWaterproof), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonPantsProtection), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonPantsMobility), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonPantsWeight), SettingsModClothes.modClothesSettings.prisonPack);

			SetFieldVisible(nameof(prisonShirtWarmth), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonShirtWetWarmth), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonShirtWindproof), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonShirtWaterproof), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonShirtProtection), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonShirtMobility), SettingsModClothes.modClothesSettings.prisonPack);
			SetFieldVisible(nameof(prisonShirtWeight), SettingsModClothes.modClothesSettings.prisonPack);

		}
		protected override void OnConfirm()
		{
			base.OnConfirm();
		}
	}

	internal static class SettingsModClothes
	{
		public static ClothingTweakerModClothesSettings modClothesSettings;

		public static void OnLoad()
		{
			modClothesSettings = new ClothingTweakerModClothesSettings("ClothingTweakerModClothes");
			modClothesSettings.AddToModSettings("Clothing Tweaker: Mod Clothes");
			modClothesSettings.RefreshFields();
		}
	}
}