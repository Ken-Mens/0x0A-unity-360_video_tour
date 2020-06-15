using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_open : MonoBehaviour
{
    public GameObject Panel;

    public void Open_panel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}
