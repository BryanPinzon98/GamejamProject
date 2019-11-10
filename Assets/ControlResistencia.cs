using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlResistencia : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnParticleCollision (GameObject other) {
        Destroy(transform.gameObject);
        //Destroy(other, 0f);
    }
}