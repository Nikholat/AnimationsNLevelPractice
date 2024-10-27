using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button menuButton;
    [SerializeField] private GameObject menu;
    private bool isIteractable = false;

    void Start()
    {
        menu.SetActive(false);
        menuButton.onClick.AddListener(ToggleMenu);
    }

    public void ToggleMenu()
    {
        isIteractable = !isIteractable;
        menu.SetActive(isIteractable);
    }
}
