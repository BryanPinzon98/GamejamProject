
using UnityEngine;
public class Sonido : MonoBehaviour{
    public AudioClip soundFile;

    void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("xdxdxdxd");
            GetComponent<AudioSource>().clip = soundFile;
            GetComponent<AudioSource>().Play();
        }

        else{
            GetComponent<AudioSource>().Stop();
        }
    }
}
