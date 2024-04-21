using Coders_Mod_Menu.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement mods for the menu."},
                new ButtonInfo { buttonText = "Visual Mods", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the Visual Mods for the menu."},
                new ButtonInfo { buttonText = "Trolling Mods", method =() => SettingsMods.GhsotMods(), isTogglable = false, toolTip = "Opens the Trolling Mods for the menu."},
                
            },

            new ButtonInfo[] { // Settings
                /*new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement Mods", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile Mods", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},*/
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.platforms(), toolTip = "R grip or L grip to spawn in a Platforms!"},
                new ButtonInfo { buttonText = "Fly", method =() => Movement.fly(), toolTip = "B button to Fly!"},
                new ButtonInfo { buttonText = "Noclip", method =() => Movement.noclip(), toolTip = "RT to noclip"},
                new ButtonInfo { buttonText = "Rig gun[NW]", method =() => Movement.RigGun(), toolTip = "Point Where Your Want Monke To Go"},
                new ButtonInfo { buttonText = "Low Grav", method =() => Movement.ZeroGrav(), toolTip = "be a space monke!"},
                new ButtonInfo { buttonText = "Mosa Speed", method =() => Movement.Speed(), disableMethod =() => Movement.FixSpeedBoost(), toolTip = "mosa speed"},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Tracers", method =() => Visul.Tracers(), toolTip = "Makes a line from your right hand to every player in the lobby!"},

            },

            new ButtonInfo[] { // Trolling Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the Mods for the menu."},
                new ButtonInfo { buttonText = "Ghost Monke", method =() => Trolling_Mods.ghostmonke(), toolTip = "Out Of Body Experience(Hold B)"},
                new ButtonInfo { buttonText = "invis Monke", method =() => Trolling_Mods.invismonke(), toolTip = "be like your dad :) and mines :("},
                new ButtonInfo { buttonText = "Long Arms", method =() => Trolling_Mods.LongArms(), disableMethod =() => Trolling_Mods.unLongArms(), toolTip = "Big Armed Monke!"},
            },
        };
    }
}
