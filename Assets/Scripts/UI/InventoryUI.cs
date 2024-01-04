using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject target;
    
    private bool _isOpen = false;

    private void RefreshInventory()
    {
        target.SetActive(_isOpen);
    }

    public void CloseInventory()
    {
        _isOpen = false;
        RefreshInventory();
    }
    
    public void OpenInventory()
    {
        _isOpen = true;
        RefreshInventory();
    }
}