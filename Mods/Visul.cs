using System;
using System.Collections.Generic;
using System.Text;
using GorillaLocomotion.Gameplay;
using GorillaTag;
using GorillaTag.Cosmetics;
using ExitGames.Client.Photon;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;
using UnityEditor.XR;
using GorillaLocomotion;
using GorillaExtensions;
using GorillaNetworking;
using GorillaTag;
using UnityEngine;
using UnityEngine.XR;
using MonoMod.RuntimeDetour.Platforms;
using Pathfinding.RVO;
using UnityEngine.UIElements;

namespace Coders_Mod_Menu.Mods
{
    internal class Visul
    {
        public static void Tracers()
        {
            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {

                if (rig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject Line = new GameObject("Line");
                    LineRenderer liner = Line.AddComponent<LineRenderer>();
                    liner.SetWidth(0.025f, 0.025f);
                    if (rig.mainSkin.material.name.Contains("fected"))
                    {
                        liner.startColor = Color.red;
                        liner.endColor = Color.red;
                    }
                    else
                    {
                        liner.startColor = Color.green;
                        liner.endColor = Color.green;
                    }
                    liner.startWidth = 0.025f; 
                    liner.endWidth = 0.025f; 
                    liner.positionCount = 2; 
                    liner.useWorldSpace = true;
                    liner.material.shader = Shader.Find("GUI/Text Shader");
                    liner.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                    liner.SetPosition(1, rig.transform.position);
                    GameObject.Destroy(liner, Time.deltaTime);


                }
            }
        }
        public static void boxesp()
        {
            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {
                if (rig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject Box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Box.transform.localPosition = rig.transform.localPosition;
                    if (rig.mainSkin.material.name.Contains("fected"))
                    {
                        Box.GetComponent<Material>().color = Color.red;
                    }
                    else
                    {
                        Box.GetComponent<Material>().color = Color.green;

                    }
                    Box.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Box.GetComponent<Material>().shader = Shader.Find("GUI/Text Shader");
                    UnityEngine.Object.Destroy(Box.GetComponent<BoxCollider>());
                    Box.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                    UnityEngine.Object.Destroy(Box.GetComponent<Rigidbody>());
                    GameObject.Destroy(Box.GetComponent<Collider>());
                    GameObject.Destroy(Box, Time.deltaTime);




                }
            }
        }    }    
}        
