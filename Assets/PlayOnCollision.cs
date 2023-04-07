using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour {


  void onCollision () {
    GetComponent<AudioSource> ().Play();
  }
}
