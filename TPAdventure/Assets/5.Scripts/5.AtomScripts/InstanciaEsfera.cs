using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEsfera : MonoBehaviour
{
    float contgen = 0f;
    float InstTime = (Mathf.PI / 20f), i = 0f;
    float InstTime2 = (Mathf.PI / 20f), j = 0f;
    float InstTime3 = (Mathf.PI / 20f), k = 0f;
    float InstTime4 = (Mathf.PI / 20f), p = 0f;

    public GameObject Esfera;
    public GameObject HorizontalEsfera;
    public GameObject SphereTilt1;
    public GameObject SphereTilt2;
    void Update()
    {
        contgen += Time.deltaTime * .5f;
        
        
        if (contgen >= (Mathf.PI / 2f))
        {
            Instancia();
        }
        /*if (contgen >= (Mathf.PI / 2f))
        {
            InstanciaT1();
        }*/
        if (contgen >= Mathf.PI)
        {
            InstanciaH();
        }
        /*if (contgen >= Mathf.PI)
        {
            InstanciaT2();
        }*/
    }

    void Instancia()
    {
        InstTime -= Time.deltaTime * .5f;
        if (InstTime <= 0)
        {
            i++;
            InstTime = (Mathf.PI / 20f);

            if (i <= 40)
            {
                Instantiate(Esfera, new Vector3(0f, 0f, 0f), Esfera.transform.rotation);
            }
        }
    }

    void InstanciaH()
    {
        InstTime2 -= Time.deltaTime * .5f;
        if (InstTime2 <= 0)
        {
            j++;
            InstTime2 = (Mathf.PI / 20f);

            if (j <= 40)
            {
                Instantiate(HorizontalEsfera, new Vector3(0f, 0f, 0f), HorizontalEsfera.transform.rotation);
            }
        }
    }

    void InstanciaT1()
    {
        InstTime3 -= Time.deltaTime * .5f;
        if (InstTime3 <= 0)
        {
            k++;
            InstTime3 = (Mathf.PI / 20f);

            if (k <= 40)
            {
                Instantiate(SphereTilt1, new Vector3(0f, 0f, 0f), SphereTilt1.transform.rotation);
            }
        }
    }

    void InstanciaT2()
    {
        InstTime4 -= Time.deltaTime * .5f;
        if (InstTime4 <= 0)
        {
            p++;
            InstTime4 = (Mathf.PI / 20f);

            if (p <= 40)
            {
                Instantiate(SphereTilt2, new Vector3(0f, 0f, 0f), SphereTilt2.transform.rotation);
            }
        }
    }
}
