using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] menus;
    [SerializeField] private GameObject unactive;
    private int currentMenu = -1;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (currentMenu == -1)
                unactive.SetActive(false);
            NextMenu();
        }
    }

    private void NextMenu()
    {
        currentMenu++;
        if (currentMenu >= menus.Length)
            currentMenu = 0;
        ActivateMenu();
    }

    private void ActivateMenu ()
    {
        ActivateMenu(currentMenu);
    }

    private void ActivateMenu (int n)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].gameObject.SetActive(i == n);
        }
    }
}
