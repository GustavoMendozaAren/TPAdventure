using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    float contador = 0f, x, y, z, z2;
    void Start()
    {
        //transform.Rotate(new Vector3(0, 0, 1), 45, Space.Self);
    }
    void Update()
    {

        //transform.Rotate(Vector3.up, Time.deltaTime * 5f);


        contador += Time.deltaTime;

        x = 65 * -(Mathf.Cos(contador + (3.1416f / 4f)));
        y = 0f;
        z = 65 * (Mathf.Sin(contador + (3.1416f / 4f)));

        transform.position = new Vector3(x, y, z); 

        transform.localPosition = new Vector3(x, y, z);
    }

    //Assign a GameObject in the Inspector to rotate around
    /*public GameObject target;

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, 90 * Time.deltaTime);
    }*/
}
