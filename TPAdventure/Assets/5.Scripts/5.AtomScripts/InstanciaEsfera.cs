using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEsfera : MonoBehaviour
{
    float contgen = 0f;
    float InstTime = 360f / 40f, i = 0f;
    float InstTime2 = 360f / 40f, j = 0f;
    float InstTime3 = 360f / 40f, k = 0f;
    float InstTime4 = 360f / 40f, p = 0f;

    public GameObject Esfera;
    public GameObject HorizontalEsfera;
    public GameObject SphereTilt1;
    public GameObject SphereTilt2;
    void Update()
    {
        contgen += .22f;

        Instancia();
        InstanciaH();

        /*if (contgen >= 360f / 4f)
        {
            Instancia();
        }*/
        /*if (contgen >= (360f / 2f))
        {
            InstanciaT1();
        }*/
        /*if (contgen >= (360f / 4f) * 3f)
        {
            InstanciaH();
        }*/
        /*if (contgen >= 360f)
        {
            InstanciaT2();
        }*/
    }

    void Instancia()
    {
        InstTime -= .11f;
        if (InstTime <= 0)
        {
            i++;
            InstTime = 360f / 40f;

            if (i <= 80f)
            {
                Instantiate(Esfera, new Vector3(0f, 0f, 0f), Esfera.transform.rotation);
            }
        }
    }

    void InstanciaH()
    {
        InstTime2 -= .11f;
        if (InstTime2 <= 0)
        {
            j++;
            InstTime2 = 360f / 40f;

            if (j <= 80f)
            {
                Instantiate(HorizontalEsfera, new Vector3(0f, 0f, 0f), HorizontalEsfera.transform.rotation);
            }
        }
    }

    void InstanciaT1()
    {
        InstTime3 -= .22f;
        if (InstTime3 <= 0)
        {
            k++;
            InstTime3 = 360f / 40f;

            if (k <= 80f)
            {
                Instantiate(SphereTilt1, new Vector3(0f, 0f, 0f), SphereTilt1.transform.rotation);
            }
        }
    }

    void InstanciaT2()
    {
        InstTime4 -= .22f;
        if (InstTime4 <= 0)
        {
            p++;
            InstTime4 = 360f / 40f;

            if (p <= 80f)
            {
                Instantiate(SphereTilt2, new Vector3(0f, 0f, 0f), SphereTilt2.transform.rotation);
            }
        }
    }
}
