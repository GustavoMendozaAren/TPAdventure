using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCent : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * 12.5f));
    }
}
