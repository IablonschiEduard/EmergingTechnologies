using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphereCollision : MonoBehaviour
{
    public bool BlueCondition = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlueCube")
        {
            Debug.Log("The blue cube is in the right place!");
            BlueCondition = true;
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
