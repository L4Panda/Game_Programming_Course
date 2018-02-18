using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Cannonball : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.tag == "Player")
        {
            Debug.Log("The player was hit!");
        }
    }
    
}
