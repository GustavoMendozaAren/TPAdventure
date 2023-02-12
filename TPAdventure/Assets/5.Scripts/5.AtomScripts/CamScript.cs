using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 0.02f));

    }
}
