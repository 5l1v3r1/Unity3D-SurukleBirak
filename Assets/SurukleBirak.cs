using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurukleBirak : MonoBehaviour
{

    Vector3 objePozisyon;


    private void OnMouseDown()
    {
        objePozisyon = Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDrag()
    {
        Vector3 poz = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objePozisyon.z);
        transform.position = Camera.main.ScreenToWorldPoint(poz);
    }


}
