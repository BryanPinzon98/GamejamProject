using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elf_Controller : MonoBehaviour {

    private Animator anim;
    public ParticleSystem poder;
    public GameObject canvas;
    private Text textoPoder;


    // Start is called before the first frame update
    void Start () {
        anim = GetComponent<Animator> ();
        textoPoder = canvas.GetComponentInChildren<Text>();
        textoPoder.text = "";
        LanzarPoder();
        showPowerTextFeedback();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown ("Fire1")) {
            LanzarPoder ();
        }
    }

    public void showPowerTextFeedback(){
        textoPoder.text = "¡Presiona la tecla Ctrl Izq para lanzar poderes!";
        StartCoroutine(hidePowerText());
    }

    public IEnumerator hidePowerText(){
        yield return new WaitForSecondsRealtime(7.0f);
        textoPoder.text = "";
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