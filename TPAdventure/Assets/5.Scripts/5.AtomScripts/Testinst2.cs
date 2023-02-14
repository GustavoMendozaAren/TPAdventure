using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testinst2 : MonoBehaviour
{
    float x, y, z, contador = 0f, velocidad = 0f, Tiempo = 0f, DivAc = 20f;
    float velF = 0f, i = 0f, j = 10f;
    
    void Update()
    {
        velocidad += (Time.deltaTime * 8) / DivAc;

        Aceleracion();

        print(velocidad);
        //contador += (Time.deltaTime * 5f) / j;      
    }

    /*public void Aceleracion()
    {
        i += Time.deltaTime;

        if (i >= .2f)
        {

            i = 0f;
            if (j >= 3)
            {
                j -= 1f;
            }
            else if (j < 3 && j > 1.1f)
            {
                j -= .1f;
            }
            else if (j <= 1.1f)
            {
                j = 1;
            }
        }
    }*/

    private void Aceleracion()
    {
        Tiempo += Time.deltaTime;

        if (Tiempo >= 1f)
        {
            Tiempo = 0f;

            if (DivAc >= 8f)
            {
                DivAc -= 3f;
                print("---------------- + " + DivAc);
            }
            else if (DivAc < 8f && DivAc >= 2.6f)
            {
                DivAc -= .6f;
                print("B + " + DivAc);
            }
            else if (DivAc < 2.6f && DivAc >= 1.2f)
            {
                DivAc -= .2f;
                print("C + " + DivAc);
            }
            else
            {
                DivAc = 1f;
                print("D + " + DivAc);
            }
        }

        transform.position = new Vector3(0f, 0f, velocidad);
    }

}
