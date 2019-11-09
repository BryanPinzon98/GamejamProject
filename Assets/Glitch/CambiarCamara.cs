using UnityEngine;
public class CambiarCamara : MonoBehaviour{

    public Camera camera1;
    public Camera camera2;

    void Start(){
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void OnTriggerEnter(){
        camera1.enabled = false;
        camera2.enabled = true;
    }

    void OnTriggerExit(){
        camera1.enabled = true;
        camera2.enabled = false;
    }
}