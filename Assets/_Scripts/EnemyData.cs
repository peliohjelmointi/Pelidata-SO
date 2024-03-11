using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public string description;
    public GameObject enemyPrefab;
    public int health = 20;
    public float speed = 2f;
    public float detectRange = 10f;
    public int damage = 1;

    //No start method, but awake, onEnable, onDisable
}
