using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    float x, y, z, contador = 0f, cont2 = 0f, i = -20f, j = -1f;

    float speed = 0f;
    float acc = 100f;
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 0.11f));

        cont2 += .11f;

        //if(cont2 >= 300f)
        //{
            if (i < -2f)
            {
                i =  i + .01f;
            }
            else
            {
                i = -2f;
            }
            if( contador > -220f)
            {
            contador += ((Time.deltaTime * 20f) / i);
            }
            else
            {
            j = j - .01f;
            contador += ((Time.deltaTime * 20f) / j);
            }
            if (j < -20f)
            {
            j = -20f;
            }
            if(contador < -280f)
            {
            contador = -280f;
            }

            //speed -= 8f * Time.deltaTime;
            
            transform.position = new Vector3(0f, 0f,-55f + contador);
            /*print(i);
            print("A + " + contador);
            print("B + " + j);*/
            //transform.position = Vector3.Lerp(transform.position, new Vector3(0f, 0f, -260f), Time.deltaTime);
        //}

    }
}
