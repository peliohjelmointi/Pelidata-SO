using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField]ItemSO item;
    [SerializeField] GameObject countText;

    private void Start()
    {
        GameObject go = Instantiate(item.itemPrefab);
        item.totalCount += 1;
        go.transform.position = Vector3.zero;
        StartCoroutine(SpawnItem(item));
    }


    private void Update()
    {
        countText.GetComponent<TextMeshProUGUI>().text = item.totalCount.ToString();
    }

    IEnumerator SpawnItem(ItemSO item)
    {
        yield return new WaitForSeconds(3);
        GameObject go = Instantiate(item.itemPrefab);
        item.totalCount += 1;
        go.transform.position = Vector3.zero;
    }
}
