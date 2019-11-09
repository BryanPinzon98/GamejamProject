using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jugar(){
        Console.WriteLine("Jugar");
        SceneManager.LoadScene("StartScene");

    }

    public void salir(){
        Console.WriteLine("Salir");
    }
}
