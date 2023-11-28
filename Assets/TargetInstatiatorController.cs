using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInstatiatorController : MonoBehaviour
{

    public Transform[] targetPlace;
    public GameObject target;

    private int randomNumPos;
    private int randomNumRGB;
    private Color colorRandom;

    // Start is called before the first frame update
    void Start()
    {
        randomNumPos = Random.Range(0, 2);
        randomNumRGB = Random.Range(1, 3);
        
        switch (randomNumRGB)
        {
            case 3:
                colorRandom = Color.blue;
                break;
            case 2:
                colorRandom = Color.green;
                break;
            case 1:
                colorRandom = Color.red;
                break;
            default:
                print("Error, color inexistent.");
                break;
        }
        GameObject targetColored = Instantiate(target, new Vector3(targetPlace[randomNumPos].position.x,
                                                                   targetPlace[randomNumPos].position.y, 
                                                                   targetPlace[randomNumPos].position.z), 
                                                                   Quaternion.identity);
        targetColored.GetComponent<Renderer> ().material.color = colorRandom;

    }
    //Add target in loop and with time to destroy
    //randomize color
    //randomize position
    //Add slow movement
    //randomize movement
    // Update is called once per frame
    //make colision with color projectile
    void Update()
    {
        
    }
}
