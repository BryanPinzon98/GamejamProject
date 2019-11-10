using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class manager : MonoBehaviour
{

    public GameObject bobina, radio, peligro, herramientas, tanque, 
                      bobinaNegra, radioNegro,peligroNegro, HerramientasNegro, tanqueNegro;

    Vector2 bobinaIniPos, radioIniPos, peligroIniPos, HerramientasIniPos, tanqueIniPos;

    /*
    string str = "";
    public string word;
    */
    //public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, forCorrect ,fiveCorrect= false;
    
    Vector3 iniScalebobina, iniScaleradio, iniScalepeligro, iniScaleherramientas, iniScaletanque, iniScaleLettreSix,
            iniScaleLettreSeven, iniScaleLettreEight;

    void Start()
    {
        bobinaIniPos = bobina.transform.position;
        radioIniPos = radio.transform.position;
        peligroIniPos = peligro.transform.position;
        HerramientasIniPos = herramientas.transform.position;
        tanqueIniPos = tanque.transform.position;

        iniScalebobina = bobina.transform.localScale;
        iniScaleradio = radio.transform.localScale;
        iniScalepeligro = peligro.transform.localScale;
        iniScaleherramientas = herramientas.transform.localScale;
        iniScaletanque = tanque.transform.localScale;
        
    }
        
    //*****************************************Drag
  
    public void DragBobina()
    {
        bobina.transform.position = Input.mousePosition;
    }
    /*
    public void DragRadio()
    {
        radio.transform.position = Input.mousePosition;
    }
    public void DragPeligro()
    {
        peligro.transform.position = Input.mousePosition;
    }
    public void DragHerramientas()
    {
        herramientas.transform.position = Input.mousePosition;
    }
    public void DragTanque()
    {
        tanque.transform.position = Input.mousePosition;
    }
    */
    //****************************************Drop    
    public void Dropbobina()
    {
        float Distance = Vector3.Distance(bobina.transform.position, bobinaNegra.transform.position);
        float Distance2 = Vector3.Distance(radio.transform.position, radioNegro.transform.position);
        float Distance3 = Vector3.Distance(peligro.transform.position, peligroNegro.transform.position);
        float Distance4 = Vector3.Distance(herramientas.transform.position, HerramientasNegro.transform.position);
        float Distance5 = Vector3.Distance(tanque.transform.position, tanqueNegro.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            bobina.transform.localScale = bobinaNegra.transform.localScale;
            bobina.transform.position = bobinaNegra.transform.position;
            oneCorrect = true;
            bobinaNegra.name = bobina.name;


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            bobina.transform.localScale = radioNegro.transform.localScale;
            bobina.transform.position = radioNegro.transform.position;
            twoCorrect = true;
            radioNegro.name = bobina.name;

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            bobina.transform.localScale = peligroNegro.transform.localScale;
            bobina.transform.position = peligroNegro.transform.position;
            threeCorrect = true;
            peligroNegro.name = bobina.name;
            
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            bobina.transform.localScale = HerramientasNegro.transform.localScale;
            bobina.transform.position = HerramientasNegro.transform.position;
            forCorrect = true;
            HerramientasNegro.name = bobina.name;
            
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            bobina.transform.localScale = tanqueNegro.transform.localScale;
            bobina.transform.position = tanqueNegro.transform.position;
            fiveCorrect = true;
            tanqueNegro.name = bobina.name;
            
        }


        else
        {
            bobina.transform.position = bobinaIniPos;
            
        }
        
    }
      /*  
    public void Dropradio()
    {
        float Distance = Vector3.Distance(radio.transform.position, bobinaNegra.transform.position);
        float Distance2 = Vector3.Distance(radio.transform.position, radioNegro.transform.position);
        float Distance3 = Vector3.Distance(radio.transform.position, peligroNegro.transform.position);
        float Distance4 = Vector3.Distance(radio.transform.position, HerramientasNegro.transform.position);
        float Distance5 = Vector3.Distance(radio.transform.position, tanqueNegro.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            radio.transform.localScale = bobinaNegra.transform.localScale;
            radio.transform.position = bobinaNegra.transform.position;
            oneCorrect = true;
            bobinaNegra.name = radio.name;
         
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            radio.transform.localScale = radioNegro.transform.localScale;
            radio.transform.position = radioNegro.transform.position;
            twoCorrect = true;
            radioNegro.name = radio.name;
            
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            radio.transform.localScale = peligroNegro.transform.localScale;
            radio.transform.position = peligroNegro.transform.position;
            threeCorrect = true;
            peligroNegro.name = radio.name;
            
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            radio.transform.localScale = HerramientasNegro.transform.localScale;
            radio.transform.position = HerramientasNegro.transform.position;
            forCorrect = true;
            HerramientasNegro.name = radio.name;
            

        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            radio.transform.localScale = tanqueNegro.transform.localScale;
            radio.transform.position = tanqueNegro.transform.position;
            fiveCorrect = true;
            tanqueNegro.name = radio.name;
            
        }

        else
        {
            radio.transform.position = radioIniPos;
            
        }

    }
    
    public void Droppeligro()
    {
        float Distance = Vector3.Distance(peligro.transform.position, bobinaNegra.transform.position);
        float Distance2 = Vector3.Distance(peligro.transform.position, radioNegro.transform.position);
        float Distance3 = Vector3.Distance(peligro.transform.position, peligroNegro.transform.position);
        float Distance4 = Vector3.Distance(peligro.transform.position, HerramientasNegro.transform.position);
        float Distance5 = Vector3.Distance(peligro.transform.position, tanqueNegro.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            peligro.transform.localScale = bobinaNegra.transform.localScale;
            peligro.transform.position = bobinaNegra.transform.position;
            oneCorrect = true;
            bobinaNegra.name = peligro.name;
            
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            peligro.transform.localScale = radioNegro.transform.localScale;
            peligro.transform.position = radioNegro.transform.position;
            twoCorrect = true;
            radioNegro.name = peligro.name;
            
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            peligro.transform.localScale = peligroNegro.transform.localScale;
            peligro.transform.position = peligroNegro.transform.position;
            threeCorrect = true;
            peligroNegro.name = peligro.name;
            
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            peligro.transform.localScale = HerramientasNegro.transform.localScale;
            peligro.transform.position = HerramientasNegro.transform.position;
            forCorrect = true;
            HerramientasNegro.name = peligro.name;
            
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            peligro.transform.localScale = tanqueNegro.transform.localScale;
            peligro.transform.position = tanqueNegro.transform.position;
            fiveCorrect = true;
            tanqueNegro.name = peligro.name;
            
        }

        else
        {
            peligro.transform.position = peligroIniPos;
            
        }

    }
   
    public void DropHerramientas() 
    {
        float Distance = Vector3.Distance(herramientas.transform.position, bobinaNegra.transform.position);
        float Distance2 = Vector3.Distance(herramientas.transform.position, radioNegro.transform.position);
        float Distance3 = Vector3.Distance(herramientas.transform.position, peligroNegro.transform.position);
        float Distance4 = Vector3.Distance(herramientas.transform.position, HerramientasNegro.transform.position);
        float Distance5 = Vector3.Distance(herramientas.transform.position, tanqueNegro.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            herramientas.transform.localScale = bobinaNegra.transform.localScale;
            herramientas.transform.position = bobinaNegra.transform.position;
            oneCorrect = true;
            bobinaNegra.name = herramientas.name;
            
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            herramientas.transform.localScale = radioNegro.transform.localScale;
            herramientas.transform.position = radioNegro.transform.position;
            twoCorrect = true;
            radioNegro.name = herramientas.name;
            
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            herramientas.transform.localScale = peligroNegro.transform.localScale;
            herramientas.transform.position = peligroNegro.transform.position;
            threeCorrect = true;
            peligroNegro.name = herramientas.name;
            
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            herramientas.transform.localScale = HerramientasNegro.transform.localScale;
            herramientas.transform.position = HerramientasNegro.transform.position;
            forCorrect = true;
            HerramientasNegro.name = herramientas.name;
            
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            herramientas.transform.localScale = tanqueNegro.transform.localScale;
            herramientas.transform.position = tanqueNegro.transform.position;
            fiveCorrect = true;
            tanqueNegro.name = herramientas.name;
            
        }

        else
        {
            herramientas.transform.position = HerramientasIniPos;
            
        }

    }

    public void DropTanque()
    {
        float Distance = Vector3.Distance(tanque.transform.position, bobinaNegra.transform.position);
        float Distance2 = Vector3.Distance(tanque.transform.position, radioNegro.transform.position);
        float Distance3 = Vector3.Distance(tanque.transform.position, peligroNegro.transform.position);
        float Distance4 = Vector3.Distance(tanque.transform.position, HerramientasNegro.transform.position);
        float Distance5 = Vector3.Distance(tanque.transform.position, tanqueNegro.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            tanque.transform.localScale = bobinaNegra.transform.localScale;
            tanque.transform.position = bobinaNegra.transform.position;
            oneCorrect = true;
            bobinaNegra.name = tanque.name;
            
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            tanque.transform.localScale = radioNegro.transform.localScale;
            tanque.transform.position = radioNegro.transform.position;
            twoCorrect = true;
            radioNegro.name = tanque.name;
            
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            tanque.transform.localScale = peligroNegro.transform.localScale;
            tanque.transform.position = peligroNegro.transform.position;
            threeCorrect = true;
            peligroNegro.name = tanque.name;
            
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            tanque.transform.localScale = HerramientasNegro.transform.localScale;
            tanque.transform.position = HerramientasNegro.transform.position;
            forCorrect = true;
            HerramientasNegro.name = tanque.name;
            
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            tanque.transform.localScale = tanqueNegro.transform.localScale;
            tanque.transform.position = tanqueNegro.transform.position;
            fiveCorrect = true;
            tanqueNegro.name = tanque.name;
            
        }

        else
        {
            tanque.transform.position = tanqueIniPos;
            
        }

    }
    */
    //Button
    /*
    public void Check()
    {


        str = tanqueNegro.name + HerramientasNegro.name + peligroNegro.name + radioNegro.name + bobinaNegra.name;

        if (word == str)
        {

            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            StartCoroutine(LoadNextPanel());

        }
        else
        {
            source.clip = incorrect;
            source.Play();

        }

    }*/

    public void Reload()
    {
       //     str = "";

       // source.clip = reload;
        //source.Play();

        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        forCorrect = false;

        bobinaNegra.name = "1";
        radioNegro.name = "2";
        peligroNegro.name = "3";
        HerramientasNegro.name = "4";
        tanqueNegro.name = "5";

        bobina.transform.position = bobinaIniPos;
        radio.transform.position = radioIniPos;
        peligro.transform.position = peligroIniPos;
        herramientas.transform.position = HerramientasIniPos;
        tanque.transform.position = tanqueIniPos;

         bobina.transform.localScale = iniScalebobina;
        radio.transform.localScale = iniScaleradio;
        peligro.transform.localScale = iniScalepeligro;
        herramientas.transform.localScale = iniScaleherramientas;
        tanque.transform.localScale = tanqueIniPos;

    }
    /*
    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }*/
    

}

