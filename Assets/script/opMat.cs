﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class opMat : MonoBehaviour
{

    public Text sin1, sin2, signo;
    public InputField res;
    public GameObject menos;
    private AudioSource audioSource;
    public AudioClip correctOptionSound;
    public AudioClip errorOptionSound;
    //private bool isPlayed;
    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        int si1=0;
        int si2 = 0;
        si1 =UnityEngine.Random.Range(1, 100);
        si2= UnityEngine.Random.Range(1, 100);
           do
            {
            si2 = UnityEngine.Random.Range(1, 100);
             }
            while (si1 == si2 && si1<=si2);
            sin1.text = si1.ToString();
            sin2.text = si2.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        
        int num1 = Int32.Parse(sin1.text);
        int num2 = Int32.Parse(sin2.text);
        int respu = Int32.Parse(res.text);
        if (num1 - num2 == respu)
        {
            Destroy(menos);
            sin1.text = "Bien ";
            sin2.text = "Hecho ";
            audioSource.PlayOneShot(correctOptionSound);
            StartCoroutine(waitForGame());        
        }
        else
        {
            sin1.text = "Mal ";
            sin2.text = "Hecho ";
            audioSource.PlayOneShot(errorOptionSound);
            Start();
        }
    }

    public IEnumerator waitForGame(){
        yield return new WaitForSecondsRealtime(1.0f);
        SceneManager.UnloadSceneAsync("MiniGame1");
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
    }
