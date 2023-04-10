using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class mainMenu : MonoBehaviour
{
    public Button mainMenuButton;
    void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
