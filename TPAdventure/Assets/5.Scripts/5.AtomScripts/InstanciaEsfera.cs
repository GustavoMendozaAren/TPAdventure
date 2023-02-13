using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEsfera : MonoBehaviour
{
    float InstTime = 360f / 48f, i = 0f;
    float InstTime2 = 360f / 48f, j = 0f;

    public GameObject Esfera;
    public GameObject HorizontalEsfera;
    void Update()
    {
        Instancia();
        InstanciaH();
    }

    void Instancia()
    {
        InstTime -= Time.deltaTime * 60f;
        if (InstTime <= 0)
        {
            i++;
            InstTime = 360f / 48f;

            if (i <= 96f)
            {
                Instantiate(Esfera, new Vector3(0f, 0f, 0f), Esfera.transform.rotation);
            }
        }
    }

    void InstanciaH()
    {
        InstTime2 -= Time.deltaTime * 60f;
        if (InstTime2 <= 0)
        {
            j++;
            InstTime2 = 360f / 48f;

            if (j <= 96f)
            {
                Instantiate(HorizontalEsfera, new Vector3(0f, 0f, 0f), HorizontalEsfera.transform.rotation);
            }
        }
    }

}
