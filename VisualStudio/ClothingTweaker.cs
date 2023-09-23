namespace ClothingTweaker
{
    public class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();

            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            SettingsMain.OnLoad();
            SettingsAccessories.OnLoad();
            SettingsFeet.OnLoad();
            SettingsHands.OnLoad();
            SettingsHead.OnLoad();
            SettingsLegs.OnLoad();
            SettingsTorsoInner.OnLoad();
            SettingsTorsoOuter.OnLoad();
            SettingsModClothes.OnLoad();
        }
    }
}
