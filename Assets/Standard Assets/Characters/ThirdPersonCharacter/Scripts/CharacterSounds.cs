using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSounds : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip paperPickSound;
    public AudioClip firstObjectPickSound;
    public AudioClip secondObjectPickSound;
    public AudioClip thirdObjectPickSound;


    public KeyCode interaction;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision other){
        if(Input.GetKeyDown (interaction) && other.gameObject.CompareTag("Doc")){
            audioSource.PlayOneShot(paperPickSound, 5.0f);
        }

        
    }

    void OnCollisionEnter(Collision other){
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.CompareTag("RecolectableObject1")){
            audioSource.PlayOneShot(firstObjectPickSound, 5.0f);
        }
        else if(other.gameObject.CompareTag("RecolectableObject2")){
            audioSource.PlayOneShot(secondObjectPickSound, 5.0f);
        }
        else if(other.gameObject.CompareTag("RecolectableObject3")){
            audioSource.PlayOneShot(thirdObjectPickSound, 5.0f);
        }
    }
}
