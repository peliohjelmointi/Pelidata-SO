using UnityEngine;

[CreateAssetMenu(menuName ="Create Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public GameObject itemPrefab;
    public int totalCount;
}
