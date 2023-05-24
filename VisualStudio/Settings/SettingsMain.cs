using ModSettings;
using System.Reflection;

namespace ClothingTweaker
{
	public enum Choice
	{
		Default, Custom
	}

	public enum ShowHideDisable
	{
		Show, Hide, Disable
	}
	internal class ClothingTweakerMainSettings : JsonModSettings
	{
		public ClothingTweakerMainSettings(string relativeJsonFilePath) : base(relativeJsonFilePath)
		{
		}

		[Section("Clothing Tweaker Main Settings")]
		[Name("Enable Mod")]
		[Description("NO: Mod is disabled. YES: Mod is enabled.")]
		public bool modFunction = false;


		[Section("Clothing Decay Rates")]
		[Name("Decay Rates")]
		[Description("UNCHANGED: Game Default settings.\nCUSTOM: Show settings for Decay.\nDecay settings are UNAFFECTED by clothing slot menus being disabled!")]
		[Choice("Unchanged", "Custom")]
		public Choice clothingDecay = Choice.Default;

		[Name("     While Not Wearing")]
		[Description("Decay rate over time, while not wearing.\n100% = Game Default rate,\n50% = Half the Game Default rate,\n0% = No decay.")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float clothingDecayDaily = 1f;

		[Name("     While Wearing Indoors")]
		[Description("Decay while wearing indoors.\n100% = Game Default rate,\n50% = Half the Game Default rate,\n0% = No decay.")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float clothingDecayIndoors = 1f;

		[Name("     While Wearing Outdoors")]
		[Description("Decay while wearing outdoors.\n100% = Game Default rate,\n50% = Half the Game Default rate,\n0% = No decay.")]
		[Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
		public float clothingDecayOutdoors = 1f;


		[Section("Clothing Slot Menus")]
		[Name("Accessories")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		[Choice("Show", "Hide", "Disable")]
		public ShowHideDisable showAccessories = ShowHideDisable.Show;

		[Name("Show Feet")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showFeet = ShowHideDisable.Show;

		[Name("Show Hands")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showHands = ShowHideDisable.Show;

		[Name("Show Head")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showHead = ShowHideDisable.Show;

		[Name("Show Legs")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showLegs = ShowHideDisable.Show;

		[Name("Show Torso Inner")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showTorsoInner = ShowHideDisable.Show;

		[Name("Show Torso Outer")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showTorsoOuter = ShowHideDisable.Show;

		[Name("Show Mod Clothes")]
		[Description("SHOW menu; settings will be applied.\nHIDE menu; settings WILL STILL BE APPLIED.\nDISABLE menu; settings WILL NOT BE APPLIED.\nMenu will Show/Hide when you RESTART the game!")]
		public ShowHideDisable showModClothes = ShowHideDisable.Show;
		
		protected override void OnChange(FieldInfo field, object oldValue, object newValue)
		{
			if (field.Name == nameof(modFunction) ||
				field.Name == nameof(clothingDecay))
			{
				RefreshFields();
			}
		}

		internal void RefreshFields()
		{
			SetFieldVisible(nameof(clothingDecay), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(clothingDecayDaily), SettingsMain.mainSettings.modFunction && clothingDecay == Choice.Custom);
			SetFieldVisible(nameof(clothingDecayIndoors), SettingsMain.mainSettings.modFunction && clothingDecay == Choice.Custom);
			SetFieldVisible(nameof(clothingDecayOutdoors), SettingsMain.mainSettings.modFunction && clothingDecay == Choice.Custom);
			SetFieldVisible(nameof(showAccessories), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showFeet), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showHands), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showHead), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showLegs), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showModClothes), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showTorsoInner), SettingsMain.mainSettings.modFunction);
			SetFieldVisible(nameof(showTorsoOuter), SettingsMain.mainSettings.modFunction);
		}
	}

	internal static class SettingsMain
	{
		public static ClothingTweakerMainSettings mainSettings;

		public static void OnLoad()
		{
			mainSettings = new ClothingTweakerMainSettings("ClothingTweakerMainSettings");
			mainSettings.AddToModSettings("Clothing Tweaker Main Settings");
			mainSettings.RefreshFields();
		}
	}
}