using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Elf_Controller : MonoBehaviour {

    private Animator anim;
    public ParticleSystem poder;
    public GameObject canvas;
    private Text textoPoder;
    public Text sensacionExtraña;
    public Text finalGameText;
    private int showFirstText = 1;
    private AudioSource audioSource;
    public AudioClip powerSound;
    public AudioClip impactSound;

    // Start is called before the first frame update
    void Start () {
        anim = GetComponent<Animator> ();
        audioSource = GetComponent<AudioSource> ();
        textoPoder = canvas.GetComponentInChildren<Text> ();
        textoPoder.text = "";
        sensacionExtraña.text = "";
        finalGameText.text = "";
        LanzarPoder ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown ("Fire1")) {
            LanzarPoder ();
        }
    }

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("FinalGameCollider")) {
            finalGameText.text = "Nunca llegué a imaginar que el fin del mundo lo causarían seres fuera de este planeta";
            audioSource.PlayOneShot (impactSound, 0.5f);
            StartCoroutine(loadCredits());
        }
    }

    public IEnumerator loadCredits()
    {
        yield return new WaitForSecondsRealtime(8f);
        SceneManager.LoadScene("instructions");
    }

    public void showPowerTextFeedback () {
        textoPoder.text = "¡Presiona la tecla Ctrl Izq para lanzar poderes!";
        StartCoroutine (hidePowerText ());
    }

    public IEnumerator hidePowerText () {
        yield return new WaitForSecondsRealtime (7.0f);
        textoPoder.text = "";
    }

    public void LanzarPoder () {
        StartCoroutine (LanzaPoderCoroutine ());
    }

    public IEnumerator LanzaPoderCoroutine () {

        if (showFirstText == 1) {
            showFirstText++;
            sensacionExtraña.text = "¿Qué sucedió? Nunca me había sentido de esta forma.";
            yield return new WaitForSecondsRealtime (5.0f);
            showPowerTextFeedback ();
            sensacionExtraña.text = "";
        }

        anim.SetBool ("LanzandoPoder", true);
        yield return new WaitForSecondsRealtime (2.0f);
        poder.Play ();
        audioSource.PlayOneShot (powerSound, 0.5f);
        StartCoroutine (DetenerPoder ());
        anim.SetBool ("LanzandoPoder", false);
    }

    public IEnumerator DetenerPoder () {
        yield return new WaitForSecondsRealtime (1.0f);
        poder.Stop ();
    }
}