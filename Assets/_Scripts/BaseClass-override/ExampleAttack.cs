using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAttack : MonoBehaviour
{
    //[SerializeField] Goblin g; 

    //tai 
    //jos luokka ei peri MonoBehavioria, siit� voi my�s tehd� olion
    Goblin g = new Goblin();

    private void Start()
    {
        g.Attack(); //Mik�li Goblin-luokasta l�ytyy override Attack-metodi, k�ytet��n sit�, muutoin Attack haetaan luokasta, josta Goblin on peritty
        
    }
}
