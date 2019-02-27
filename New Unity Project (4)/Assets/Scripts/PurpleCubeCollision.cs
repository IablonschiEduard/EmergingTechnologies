using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleCubeCollision : MonoBehaviour
{
    public bool PurpleCondition = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PurpleCube")
        {
            Debug.Log("The purple cube is in the right place!");
            PurpleCondition = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
