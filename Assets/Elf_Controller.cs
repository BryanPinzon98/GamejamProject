using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf_Controller : MonoBehaviour {

    private Animator anim;
    public ParticleSystem poder;


    // Start is called before the first frame update
    void Start () {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown ("Fire1")) {
            LanzarPoder ();
        }
    }

    public void LanzarPoder () {
        StartCoroutine (LanzaPoderCoroutine ());
    }

    public IEnumerator LanzaPoderCoroutine () {
        anim.SetBool ("LanzandoPoder", true);
        yield return new WaitForSecondsRealtime (2.0f);
        poder.Play();
        StartCoroutine(DetenerPoder());
        anim.SetBool ("LanzandoPoder", false);
    }

    public IEnumerator DetenerPoder(){
        yield return new WaitForSecondsRealtime(1.0f);
        poder.Stop();
    }
}