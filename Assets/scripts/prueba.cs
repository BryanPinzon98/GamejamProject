using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{

    private Transform transformBobina;

    void Start()
    {
        transformBobina = this.gameObject.transform.GetChild(1);
        transformBobina.position = new Vector2(135, -180);

    }


}
