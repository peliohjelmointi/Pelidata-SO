using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class People : MonoBehaviour
{
    [SerializeField] TextAsset textFile;
    [SerializeField] string[] names;

    private void OnValidate()
    {
        //int y = 10;
        //int? x = y<15 ? 12 :5;
        //print(x);


        //if (y < 15)
        //    x = 12;
        //else
        //    x = 5;

        names = textFile ? textFile.text.Split(new[]
        {
                Environment.NewLine },
            StringSplitOptions.RemoveEmptyEntries) : null;
    }
}

