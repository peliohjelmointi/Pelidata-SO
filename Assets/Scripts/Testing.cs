using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public SampleSO sampleSO;

    private void Start()
    {
        Debug.Log(sampleSO.myString);
    }
}
