using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Items : MonoBehaviour
{
    [SerializeField] TextAsset itemsFile;

    public Item[] items;

    private void OnValidate()
    {
        string[] lines = itemsFile ? itemsFile.text.Split(new[]
        {Environment.NewLine },
            StringSplitOptions.RemoveEmptyEntries) : null;
        int len = lines.Length;
        items = new Item[len];
        for (int i = 0; i < len; i++)
            items[i] = ConvertToItem(lines[i]);
    }

    Item ConvertToItem(string line)
    {
        string[] parts = line.Split(',');
        return new Item
        {
            Name = parts[0],
            Price = int.TryParse(parts[1], out var p) ? p : 0,
            ItemColor = ColorUtility.TryParseHtmlString(parts[2], out Color c) ? c : Color.white
        };
    }
}
    

