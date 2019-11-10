using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class DropSlots : EventTrigger, IDropHandler
{
    public int id;
    GameObject item;
    // Start is called before the first frame update
    void Start()
    {   
    }

    public override void OnDrop(PointerEventData eventData)
    {   
        item = DragDropHandler.itemDragging;
        
        Debug.Log(item.gameObject.tag);
        Debug.Log(this.gameObject.tag);
        if (item.gameObject.tag == this.gameObject.tag)
            item.transform.SetParent(transform);// lo toma en    donde  pueda y reposiciona.
            item.transform.position = this.transform.position;
            if(this.gameObject.tag == "bobina")
                SceneManager.UnloadSceneAsync("MiniGame2");


    }
        
    // Update is called once per frame
    void Update() 
    {
        if (item != false && item.transform.parent != this.transform)
        {
            item = null;
        }
    }
}
   