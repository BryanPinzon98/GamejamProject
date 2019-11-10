using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour {

    public ParticleSystem recolectableObject1;
    public ParticleSystem recolectableObject2;
    public ParticleSystem recolectableObject3;

    // Start is called before the first frame update
    void Start () {
        recolectableObject1.Stop ();
        recolectableObject2.Stop ();
        recolectableObject3.Stop ();
    }

    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter (Collider other) {

        if (other.gameObject.CompareTag ("Light1")) {
            recolectableObject1.Play ();
        } else if (other.gameObject.CompareTag ("Light2")) {
            recolectableObject2.Play ();
        } else if (other.gameObject.CompareTag ("Light3")) {
            recolectableObject3.Play ();
        } else if (other.gameObject.CompareTag ("RecolectableObject1")){
            other.gameObject.SetActive(false);
            recolectableObject1.Stop ();
        } else if (other.gameObject.CompareTag ("RecolectableObject2")){
            other.gameObject.SetActive(false);
            recolectableObject2.Stop ();
        } else if (other.gameObject.CompareTag ("RecolectableObject3")){
            other.gameObject.SetActive(false);
            recolectableObject3.Stop ();
        }
    }
}