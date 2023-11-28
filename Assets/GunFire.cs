using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class GunFire : MonoBehaviour
    {
        //public SteamVR_Action_Boolean fireAction;
        public Interactable interactable;
        public SteamVR_Action_Boolean fireGun = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("fireAction");

        public ParticleSystem shots;
        // Start is called before the first frame update
        void Start()
        {
            //interactable.GetComponent<Interactable>();
        }

        // Update is called once per frame
        void Update()
        {
            //if (interactable.attachedToHand !=null)

            // SteamVR_Input_Sources source = interactable.attachedToHand.handType;

            //if (fireAction[source].stateDown)

            if (interactable.attachedToHand)
            {
                //Debug.Log("Attached");
                //Debug.Log(fireGun.GetState(SteamVR_Input_Sources.Any));
                if (fireGun.GetState(SteamVR_Input_Sources.Any))
                {
                    //Debug.Log("Fire outside");
                    Fire();
                    shots.Play();
                    
                }
                else
                {
                    shots.Stop();
                }
            }
            


        }

        void Fire()
        {
            Debug.Log("Fire");
        }
    }
}
