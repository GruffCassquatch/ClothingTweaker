# Clothing Tweaker
A mod for The Long Dark

## Mod features:
* Allows you to adjust the warmth, warmth when wet, windproof, waterproof, protection, mobility and weight of clothing items. 
* Allows you to adjust the decay rates for all clothing items, with separate settings for: decay while not wearing, decay while worn inside, decay while worn outside.

Now you can wear anything you want, instead of the exact same 'best' set of clothes every game! 

Includes support for the clothes added by [ClothingPack](https://github.com/ds5678/Clothing-Pack), [NorthfolkClothingPack](https://github.com/HAHAYOUDEAD/NorthfolkClothingPack), [PrisonPack](https://github.com/TheDevv/Prison-Pack) and [WolfskinScarf](https://github.com/Atlas-Lumi/TLD-WolfskinScarf)   

Based on [FurClothingMod](https://github.com/ds5678/FurClothingMod) by ds5678.

## Limitations:
  * Compatible with [Weight Tweaks](https://github.com/Xpazeman/tld-weight-tweaks), but be aware that if you use BOTH to change clothing weight, the efects are CUMULATIVE. 
      * E.g. set Weight Tweaks "Clothing Modifier" to 0.5 and also set the weight of an item to 1kg in Clothing Tweaker: that item will weigh 0.5kg (1kg x 0.5). 
      * If you only want Weight Tweaks to affect clothing weight, don't change any weight values in Clothing Tweaker.
      * If you only want Clothing Tweaker to affect clothing weight, leave the "Clothing Modifier" setting in Weight Tweaks at 1.00.
  * Compatible with [GearDecayModifier](https://github.com/Xpazeman/tld-gear-decay-modifier), but be aware that if you use BOTH to change clothing decay, the efects are CUMULATIVE. 
      * E.g. set both mods to reduce clothing decay by 50% and you will overall reduce decay by 75% (50% x 50%). 
      * Gear Decay Modifier uses ONE decay rate for all THREE types of decay (worn inside, worn outside, unworn).
      * If you only want Gear Decay Modifier to affect the decay rates, leave the Decay settings in Clothing Tweaker at 'Unchanged'.
      * If you only want Clothing Tweaker to affect the decay rates, leave the "Clothing decay rate" setting in Gear Decay Modifier at 1.

## Requirements:
[MelonLoader](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe)

[ModSettings](https://github.com/zeobviouslyfakeacc/ModSettings/releases)

## Installation:
1. Download ```ClothingTweaker.dll``` from [releases](https://github.com/GruffCassquatch/ClothingTweaker/releases)
2. Drop ```ClothingTweaker.dll``` into your Mods folder
3. If you are updating from an older version, you may need to delete the ```ClothingTweaker.json``` files from your Mods folder as old json's can cause errors if the mod's Settings have been changed.

## Uninstallation:
Delete ```ClothingTweaker.dll``` and all ```ClothingTweaker .json``` files from your Mods folder

## Using The Mod:
1. Open the ```Options``` menu
2. Open the ```Mod Settings``` menu
3. Scroll across to the ```Clothing Tweaker Main Settings``` menu
  * Choose to ```Enable``` or ```Disable``` the mod
  * Customise ```Decay``` settings or leave them Unchanged
  	* Decay settings apply to ALL clothing items and are UNAFFECTED by clothing slot menus being disabled.
  * Choose to ```Show```, ```Hide``` or ```Disable``` the individual menus for each clothing slot:
	* ```SHOW```: the menu will appear in the Mod Settings menu AND settings will be applied.
		* Use this when you want to tweak the clothing settings.
	* ```HIDE```: the menu will NOT appear in the Mod Settings menu after restarting the game AND settings WILL STILL BE APPLIED. 
		* Use this when you want to tweak the clothing settings BUT want to unclutter your Mod Settings menu afterwards.
	* ```DISABLE```: the menu will NOT appear in the Mod Settings menu after restarting the game AND settings WILL NOT BE APPLIED.
		* Use this when you DON'T want to tweak the clothing settings for that clothing slot.
	* Menus will only Show/Hide when you RESTART the game!
	* Showing/Hiding/Disabling any menus has no effect on Decay settings.

5. Scroll across to the ```Clothing Tweaker``` menus (menus are organised by clothing slot).
6. Scroll down to see all of the clothing items, change values using the sliders.
7. Click ```CONFIRM``` to apply your changes or ```BACK``` to exit without applying changes.


## To reset clothing stats to default:
1. Exit the game.
2. Delete the ```ClothingTweaker.json``` files in your Mods folder. You can just delete the files that relate to the items your want to restore to default.
3. Relaunch the game.

## Feedback, Questions & Troubleshooting
* I am active on [The Long Dark Modding](https://discord.gg/QvFE7VV4WZ) Discord server
	* **General questions and feedback:** post in my channel #cass
	* **Troubleshooting:** 
		* Post in my channel #cass or in #troubleshooting 
		* Or create an issue here on GitHub if you're not on Discord
