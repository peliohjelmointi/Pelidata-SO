using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAttack : MonoBehaviour
{
    //[SerializeField] Goblin g; 

    //tai 
    //jos luokka ei peri MonoBehavioria, siitä voi myös tehdä olion
    Goblin g = new Goblin();

    private void Start()
    {
        g.Attack(); //Mikäli Goblin-luokasta löytyy override Attack-metodi, käytetään sitä, muutoin Attack haetaan luokasta, josta Goblin on peritty
        
    }
}
