using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTest : MonoBehaviour
{

    float velocidad = 0f, Tiempo = 0f, DivAc = 20f, TiempoGen = 0f, Tiempo2 = 0f;

    void Update()
    {

        TiempoGen += Time.deltaTime;
            
        transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * 12.5f));

        velocidad -= (Time.deltaTime * 15f) / DivAc;

        if (TiempoGen < 3f)
        {
            Aceleracion();
        }
        else if (TiempoGen >= 3f && TiempoGen < 27f)
        {
            transform.position = new Vector3(0f, 0f, -55f + (velocidad));
        }
        else if (TiempoGen >= 27f)
        {
            Desaceleracion();
        }
    }

    private void Aceleracion()
    {
        Tiempo += Time.deltaTime;

        if(Tiempo >= .2f)
        {
            Tiempo = 0f;

            if (DivAc >= 8f)
            {
                DivAc -= 3f;
            }
            else if (DivAc < 8f && DivAc >= 2.6f)
            {               
                DivAc -= .6f;
            }
            else if (DivAc < 2.6f && DivAc >= 1.2f)
            {
                DivAc -= .2f;
            }
            else 
            {
                DivAc = 1f;
            }
        }

        transform.position = new Vector3(0f, 0f, -55f + velocidad);
    }

    private void Desaceleracion()
    {
        Tiempo2 += Time.deltaTime;

        if(Tiempo2 >= .2f)
        {
            Tiempo2 = 0f;

            if(DivAc <= 1.8f)
            {
                DivAc += .2f;
            }
            else if (DivAc > 1.8f && DivAc <= 4.4f)
            {
                DivAc += .6f;
            }
            else if(DivAc > 4.4f && DivAc <= 20f)
            {
                DivAc += 3f;
            }
        }

        transform.position = new Vector3(0f, 0f, -55f + velocidad);
    }
}
