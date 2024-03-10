using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    void Update()
    {
        transform.Translate(new Vector3(0, 5, 0)*Time.deltaTime); 
    }
}
