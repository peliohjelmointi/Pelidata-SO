using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Sample File", menuName ="Sample Scriptable Object")]
public class SampleSO : ScriptableObject
{
    public string myString;
    public int count;
    public Sprite[] spriteArray;

    void Awake()
    {

    }
    void OnEnable()
    {

    }
    void OnDisable()
    {

    }
}


