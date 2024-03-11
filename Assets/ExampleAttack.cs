using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAttack : MonoBehaviour
{
    //[SerializeField] Goblin g;

    Goblin g = new Goblin();

    private void Start()
    {
        g.Attack();
        
    }
}
