using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class puzzle : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0f,0f, 90f);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("asdasdasd");
        if (!GameControl.youWin) {
            transform.Rotate(0f, 0f, 90f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
