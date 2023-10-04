using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropdownLogic : MonoBehaviour
{
    public Button toggleButton; // Arrastra el bot�n izquierdo aqu� desde el Inspector.
    public GameObject dropdownPanel; // Arrastra el panel desplegable aqu� desde el Inspector.

    private bool isDropdownVisible = false;

    private void Start()
    {
        toggleButton.onClick.AddListener(ToggleDropdown);
        dropdownPanel.SetActive(false);
    }

    private void ToggleDropdown()
    {
        isDropdownVisible = !isDropdownVisible;
        dropdownPanel.SetActive(isDropdownVisible);
    }
}
