using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0, 5f, 0) * Time.deltaTime);
    }
}
