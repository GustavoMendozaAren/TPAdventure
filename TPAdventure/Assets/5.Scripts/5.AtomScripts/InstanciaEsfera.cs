using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEsfera : MonoBehaviour
{
    float contgen = 0f;
    float InstTime = (3.1416f / 10f), i = 0f;
    float InstTime2 = (3.1416f / 10f), j = 0f;

    public GameObject Esfera;
    public GameObject HorizontalEsfera;
    void Update()
    {
        contgen += Time.deltaTime * .62f;
        Instancia();
        if (contgen >= (3.1416f / 4f))
        {
            InstanciaH();
        }
    }

    void Instancia()
    {
        InstTime -= Time.deltaTime * .5f;
        if (InstTime <= 0)
        {
            i++;
            InstTime = (3.1416f / 10f);

            if (i <= 20)
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
            InstTime2 = (3.1416f / 10f);

            if (j <= 20)
            {
                Instantiate(HorizontalEsfera, new Vector3(0f, 0f, 0f), HorizontalEsfera.transform.rotation);
            }
        }
    }
}
