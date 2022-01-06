using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Script : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                Debug.Log("MouseX="+mousePos.x);
                Debug.Log("MouseY=" + mousePos.y);
            }
        }
    }
}
