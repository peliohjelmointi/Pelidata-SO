using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    [SerializeField] Items i;

    private void Start()
    {
        print(i.GetComponent<Items>().items[0].Price);
    }
}
