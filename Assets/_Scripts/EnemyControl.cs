using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyControl : MonoBehaviour
{
    public EnemyData enemyData;
    [SerializeField] GameObject enemyCountText;
    [SerializeField] GameObject totalCountText;
    [SerializeField] GameObject testing;

    int spawnCount = 0;

    SampleSO so;

    private void Awake()
    {
        so = testing.GetComponent<Testing>().sampleSO;
        
    }

    private void Start()
    {
        if (enemyData != null)
        {
            LoadEnemy(enemyData);
            StartCoroutine(InstantiateEnemy(enemyData));
        }
    }

    private void Update()
    {
        enemyCountText.GetComponent<TextMeshProUGUI>().text = spawnCount.ToString();
        totalCountText.GetComponent<TextMeshProUGUI>().text = so.count.ToString();
    }

    IEnumerator InstantiateEnemy(EnemyData ed)
    {
        yield return new WaitForSeconds(2);
        Debug.Log("SPAWGINT");
        spawnCount += 1;
        so.count += 1;
        GameObject go = Instantiate(ed.enemyPrefab);
        go.transform.SetParent(this.transform);
        go.transform.localPosition = Vector3.zero;
        go.transform.rotation = Quaternion.identity;
        
    }

    void LoadEnemy(EnemyData data)
    {
        spawnCount += 1;
        so.count += 1;
        GameObject enemyPrefab = Instantiate(data.enemyPrefab);
        enemyPrefab.transform.SetParent(this.transform);
        enemyPrefab.transform.localPosition = Vector3.zero;
        enemyPrefab.transform.rotation = Quaternion.identity;
    }
}
