using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenCheck : MonoBehaviour
{
    private PurpleCubeCollision myScript1;
    // Start is called before the first frame update
    void Start()
    {
        myScript1 = GetComponent<PurpleCubeCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myScript1.PurpleCondition)
            Debug.Log("Condition is true");

    }
    
}
