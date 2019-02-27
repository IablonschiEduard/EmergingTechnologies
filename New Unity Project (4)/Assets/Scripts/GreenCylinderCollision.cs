using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCylinderCollision : MonoBehaviour
{
    public bool GreenCondition = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenCube")
        {
            Debug.Log("The green cube is in the right place!");
            GreenCondition = true;
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
