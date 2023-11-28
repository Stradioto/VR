using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public Animation anim;
    private bool doorOpen =  false;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (doorOpen == false && anim.isPlaying == false)
        {
            anim.Play("DoorButtonWorking");
            //Debug.Log("Door Opening");
            doorOpen = true;
        }
        else if (doorOpen == true && anim.isPlaying == false)
        {
            anim.Play("DoorButtonClosing");
            //Debug.Log("Door Closing");
            doorOpen = false;
        }
        else if (anim.isPlaying)
        {
            //Debug.Log("Already actvated");
        }


    }
}
