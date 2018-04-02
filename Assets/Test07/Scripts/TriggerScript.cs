using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    public GameObject wall1;
    public GameObject wall2;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(wall1);
        Destroy(wall2);

        // peut etre audio plus tard
        
    }
}
