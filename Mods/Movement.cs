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

namespace StupidTemplate.Mods
{
    internal class Movement
    {


        public static GameObject lplat;
        public static GameObject rplat;




        public static void fly()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * Time.deltaTime * 1500f;  
            }
        }




        public static void platforms()
        {

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (lplat == null)
                {
                    lplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    lplat.transform.localScale = new Vector3(0.025f, 0.15f, 0.2f);
                    lplat.transform.localPosition = GorillaTagger.Instance.leftHandTransform.localPosition;
                    lplat.transform.localRotation = GorillaTagger.Instance.leftHandTransform.localRotation;
                    lplat.GetComponent<Material>().shader = Shader.Find("GorillaTag/UberShader");
                    lplat.GetComponent<Material>().color = Color.blue;
                    GameObject.Destroy(lplat.GetComponent<Rigidbody>());
                }
            }
            else
            {
                if( lplat != null) { GameObject.Destroy(lplat); }
            }
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (rplat == null)
                {
                    rplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    rplat.transform.localScale = new Vector3(0.025f, 0.15f, 0.2f);
                    rplat.transform.localPosition = GorillaTagger.Instance.rightHandTransform.localPosition;
                    rplat.transform.localRotation = GorillaTagger.Instance.rightHandTransform.localRotation;
                    rplat.GetComponent<Material>().shader = Shader.Find("GorillaTag/UberShader");
                    rplat.GetComponent<Material>().color = Color.blue;
                    GameObject.Destroy(rplat.GetComponent<Rigidbody>());
                }
            }
            else
            {
                if (rplat != null) { GameObject.Destroy(rplat); }
            }
        }

        public static void noclip()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5)
            {

                foreach (MeshCollider mesh in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    mesh.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider mesh in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    mesh.enabled = true;
                }
            }
        }
        public static void ZeroGrav()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (9.81f / Time.deltaTime)), ForceMode.Acceleration);

        }





        public static void Speed()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 7.3f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2.5f;
        }

        public static void FixSpeedBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 6.5f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 1.1f;
        }

        public static void RigGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                Physics.Raycast(GorillaTagger.Instance.rightHandTransform.localPosition, GorillaTagger.Instance.rightHandTransform.forward, out var rayhit);

                GameObject newgun = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                newgun.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                newgun.GetComponent<Material>().shader = Shader.Find("GUI/Text Shader");
                newgun.GetComponent<Material>().color = Color.white;
                newgun.transform.localPosition = rayhit.point;
                GameObject.Destroy(newgun.GetComponent<Rigidbody>());
                GameObject.Destroy(newgun.GetComponent<SphereCollider>());
                GameObject.Destroy(newgun.GetComponent<BoxCollider>());
                GameObject.Destroy(newgun.GetComponent<Collider>());
                GameObject.Destroy(newgun, Time.deltaTime);

                if(ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = rayhit.point;
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }

            }


        }
        
        



    }
}