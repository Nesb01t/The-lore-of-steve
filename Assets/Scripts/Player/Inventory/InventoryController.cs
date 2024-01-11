using System.Collections;
using System.Collections.Generic;
using System.IO;
using OpenCover.Framework.Model;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using Utils;
using File = System.IO.File;

public class InventoryController : MonoBehaviour
{
    List<GameObject> _slots = new List<GameObject>(new GameObject[24]);
    List<GameObject> _slots_shortcuts = new List<GameObject>(new GameObject[24]);

    private List<GameObject> _items = new List<GameObject>(new GameObject[24]);

    public GameObject defaultItem;

    void Start()
    {
        InitItemGridSlots();
        SetInventoryItem(defaultItem, 0);
        SaveInventory();
    }

    public void SaveInventory()
    {
        string filePath = Application.dataPath + @"/Resources/Inventory.json";
        FileInfo file = new FileInfo(filePath);

        StreamWriter sw = file.CreateText();
        string json = JsonUtility.ToJson(_items);
        sw.WriteLine(json);
        sw.Close();
        sw.Dispose();
    }
    
    public void AddInventoryItem(GameObject prefab)
    {
        for (int i = 0; i < 24; i++)
        {
            if (!_items[i])
            {
                SetInventoryItem(prefab, i);
                return;
            }
        }
    }

    public void SetInventoryItem(GameObject prefab, int slot)
    {
        GameObject instance = Instantiate(prefab);
        _items[slot] = instance;

        UpdateInventoryAsAViewModel();
    }

    void UpdateInventoryAsAViewModel()
    {
        for (int i = 0; i < 24; i++)
        {
            if (_slots[i])
            {
                RemoveAllChildNodes(_slots[i].transform);
            }

            if (!_items[i])
            {
                continue;
            }

            GameObject instance = Instantiate(_items[i]);
            instance.GetComponent<HoldableItem>().enabled = false;
            instance.GetComponent<PickableItem>().enabled = true;
            instance.transform.SetParent(_slots[i].transform);
        }

        for (int i = 0; i < 5; i++)
        {
            if (_slots_shortcuts[i])
            {
                RemoveAllChildNodes(_slots_shortcuts[i].transform);
            }

            if (!_items[i])
            {
                continue;
            }

            GameObject instance = Instantiate(_items[i]);
            instance.GetComponent<HoldableItem>().enabled = false;
            instance.GetComponent<PickableItem>().enabled = true;
            instance.transform.SetParent(_slots_shortcuts[i].transform);
        }
    }

    void InitItemGridSlots()
    {
        GameObject itemGrid = GameObject.Find("ItemGrid");
        for (int i = 0; i < itemGrid.transform.childCount; i++)
        {
            _slots[i] = (itemGrid.transform.GetChild(i).gameObject);
        }

        GameObject itemShortcut = GameObject.Find("Shortcut");
        for (int i = 0; i < itemShortcut.transform.childCount; i++)
        {
            _slots_shortcuts[i] = (itemShortcut.transform.GetChild(i).gameObject);
        }
    }

    void RemoveAllChildNodes(Transform transform)
    {
        int c = transform.childCount;
        for (int i = c - 1; i >= 0; i--)
        {
            if (transform.GetChild(i).name == "Quickcut")
            {
                continue;
            }

            Destroy(transform.GetChild(i).gameObject);
        }
    }
}