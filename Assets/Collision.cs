using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public string otherObjName = "SoundCube";
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == otherObjName) {
            print("collision");
        }      
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == otherObjName) {
            print("continuous collision");
        }  
    }
    
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == otherObjName) {
            print("no more collision");
        }
    }
}
