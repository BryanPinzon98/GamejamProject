using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cast : MonoBehaviour
{
    // Start is called before the first frame update
    public Text sin1, sin2;
    public InputField res;
    void Start()
    {
        
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
            sin1.text = "Bien ";
            sin2.text = "Hecho ";

        }
        else {
            sin1.text = "Mal ";
            sin2.text = "Hecho ";
        }
    }
}
