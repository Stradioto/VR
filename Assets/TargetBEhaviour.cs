using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBEhaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem explosion;
    void Start()
    {
        explosion = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Destroy(GetComponent<MeshRenderer>());
        explosion.Play();
    }
}
