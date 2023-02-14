using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEsfera : MonoBehaviour
{
    float InstTime = 10f, i = 0f;
    float InstTime2 = 10f, j = 0f;
    float InstTime3 = 10f, k = 0f;
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

        Invoke("Instancia2", 1f);
       //InstanciaH();

    }

    void Instancia()
    {
        InstTime -= Time.deltaTime * 40f;
        if (InstTime <= 0.02f)
        {
            i++;
            InstTime = 20f;

            if (i <= 40f)
            {
                Instantiate(Esfera, new Vector3(0f, 0f, 0f), Esfera.transform.rotation);
            }
        }
    }

    void InstanciaH()
    {
        InstTime2 -= Time.deltaTime * 40f;
        if (InstTime2 <= 0.02f)
        {
            j++;
            InstTime2 = 20f;

            if (j <= 40f)
            {
                Instantiate(HorizontalEsfera, new Vector3(0f, 0f, 0f), HorizontalEsfera.transform.rotation);
            }
        }
    }

    void Instancia2()
    {
        print("Hola");
        InstTime3 -= Time.deltaTime * 40f;
        if (InstTime3 <= 0.02f)
        {
            k++;
            InstTime3 = 20f;

            if (k <= 40f)
            {
                Instantiate(Esfera2, new Vector3(0f, 0f, 0f), Esfera2.transform.rotation);
            }
        }
    }

}
