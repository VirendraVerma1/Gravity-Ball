using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "MyBall")
        {
            Destroy(col.gameObject);
            print("Game Won");
        }
    }

    
}
