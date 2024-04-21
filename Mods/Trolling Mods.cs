using System;
using System.Collections.Generic;
using System.Text;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;
using UnityEditor.XR;
using GorillaLocomotion;
using GorillaExtensions;
using GorillaNetworking;
using GorillaTag;
using UnityEngine;
using UnityEngine.XR;

namespace Coders_Mod_Menu.Mods
{
    internal class Trolling_Mods
    {
        public static void ghostmonke()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void invismonke()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.localPosition = new Vector3(0f, 1000f, 0f);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }



        public static void LongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }

        public static void unLongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }


    }
}
