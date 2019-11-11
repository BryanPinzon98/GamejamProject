using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropHandler : MonoBehaviour,IDragHandler,IEndDragHandler,IBeginDragHandler
{
    public static GameObject itemDragging;

    Vector3 startPosition;
    Transform starParent;
    Transform dragParent;

    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Breg Drg");
        itemDragging = gameObject;

        startPosition = transform.position;
        starParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrg");
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("endDrag");
        itemDragging = null;
        
        if (transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(starParent);
        }
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
 