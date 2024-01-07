using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Inventory;

public class InventoryHolder : MonoBehaviour
{
    public List<InventorySlot> Inventory = new();

    void Start()
    {
        Inventory.Add(new InventorySlot(0));
    }

    void Update()
    {
    }
}