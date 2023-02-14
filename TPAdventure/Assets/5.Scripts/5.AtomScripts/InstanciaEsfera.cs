using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEsfera : MonoBehaviour
{
    float InstTime = 18f, i = 0f;
    float InstTime2 = 18f, j = 0f;
    float InstTime3 = 18f, k = 0f;
    float InstTime4 = 18f, l = 0f;
    float TimGen = 0f;

    public GameObject Esfera;
    public GameObject HorizontalEsfera;
    public GameObject Esfera2;
    public GameObject Esfera3;

    void FixedUpdate()
    {
        TimGen += Time.deltaTime;

        Instancia();
        InstanciaH();

        if(TimGen >= .25f)
        {
            Instancia2();
            Instancia3();
        }
        
        //InstanciaH();

    }

    void Instancia()
    {
        InstTime -= Time.deltaTime * 36f;
        if (InstTime <= 0.02f)
        {
            i++;
            InstTime = 18f;

            if (i <= 72f)
            {
                Instantiate(Esfera, new Vector3(0f, 0f, 0f), Esfera.transform.rotation);
            }
        }
    }

    void InstanciaH()
    {
        InstTime2 -= Time.deltaTime * 36f;
        if (InstTime2 <= 0.02f)
        {
            j++;
            InstTime2 = 18f;

            if (j <= 72f)
            {
                Instantiate(HorizontalEsfera, new Vector3(0f, 0f, 0f), HorizontalEsfera.transform.rotation);
            }
        }
    }

    void Instancia2()
    {
        InstTime3 -= Time.deltaTime *36f;
        if (InstTime3 <= 0.02f)
        {
            k++;
            InstTime3 = 18f;

            if (k <= 72f)
            {
                Instantiate(Esfera2, new Vector3(0f, 0f, 0f), Esfera2.transform.rotation);
            }
        }
    }

    void Instancia3()
    {
        InstTime4 -= Time.deltaTime * 36f;
        if (InstTime4 <= 0.02f)
        {
            l++;
            InstTime4 = 18f;

            if (l <= 72f)
            {
                Instantiate(Esfera3, new Vector3(0f, 0f, 0f), Esfera3.transform.rotation);
            }
        }
    }
}
