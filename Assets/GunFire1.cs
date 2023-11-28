using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class GunFire1 : MonoBehaviour
    {
        //public SteamVR_Action_Boolean fireAction;
        public Interactable interactable;
        public SteamVR_Action_Boolean fireGun = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("gunfire");

         public SteamVR_Action_Boolean topTouch = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("presstop");

        public ParticleSystem shots;
        public Transform shotInstantiator;
        //public GameObject bullet;
        public Rigidbody projectile;
        public float speed;

        private int colorCounter = 0;



        // Start is called before the first frame update
        void Start()
        {
            //Debug.Log(gameObject.GetComponent.material.EnableKeyword(“_EMISSION”));
            //interactable.GetComponent<Interactable>();
            Debug.Log(gameObject.GetComponent<Renderer>().material.GetColor("_EmissionColor"));
            gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);
        }

        // Update is called once per frame
        void Update()
        {
            //if (interactable.attachedToHand !=null)

            // SteamVR_Input_Sources source = interactable.attachedToHand.handType;

            //if (fireAction[source].stateDown)
            switch (colorCounter)
            {
                case 1:
                    gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
                    break;
                case 2:
                    gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.blue);
                    break;
                case 3:
                    gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.yellow);
                    break;
                default:
                    Debug.Log("error");
                    break;
            }

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
                if (topTouch.GetState(SteamVR_Input_Sources.Any)) 
                {
                    Debug.Log("Color change");
                    colorCounter++;
                }
                if (colorCounter >= 4)
                {
                    colorCounter = 1;
                }
            }
            


        }

        void Fire()
        {
            Debug.Log("Fire");
            Rigidbody clone;
            clone = Instantiate(projectile, new Vector3(shotInstantiator.position.x, shotInstantiator.position.y, shotInstantiator.position.z), Quaternion.identity);
            clone.velocity = transform.TransformDirection(Vector3.forward * speed);
            clone.GetComponent<Renderer>().material.color = gameObject.GetComponent<Renderer>().material.GetColor("_EmissionColor");
        }
    }
}
