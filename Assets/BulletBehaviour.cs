using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Rb;
    public float speed;
    //public GameObject parentOfThis;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        Rb.velocity = transform.TransformDirection(Vector3.forward * speed);
        
    }
}
