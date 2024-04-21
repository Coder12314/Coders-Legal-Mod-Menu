using System;
using System.Collections.Generic;
using System.Text;
using Utilla;

namespace Coders_Mod_Menu.Patches
{
    [ModdedGamemode]
    internal class legal_stuff
    {
       public static bool inAllowedRoom = false;

        [ModdedGamemodeJoin]
        private void RoomJoined(string gamemode)
        {
            inAllowedRoom = true;
        }

        [ModdedGamemodeLeave]
        private void RoomLeft(string gamemode)
        {
            inAllowedRoom = false;
        }
    }
}
