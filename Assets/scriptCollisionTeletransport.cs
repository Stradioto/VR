using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCollisionTeletransport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColliderEnter(Collider collider)
    {
        Debug.Log("c: " + collider);
    }
}
