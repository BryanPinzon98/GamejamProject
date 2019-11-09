using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour {

    public ParticleSystem recolectableObjects;
    // Start is called before the first frame update
    void Start () {
        recolectableObjects.Stop();
    }

    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter (Collider other) {

        if (other.gameObject.CompareTag ("RecolectableObjects")) {
            recolectableObjects.Play();
        }
    }
}