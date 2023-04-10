using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class backMenu : MonoBehaviour
{
    public Button backButton;
    void Start()
    {
        backButton.onClick.AddListener(Back);
    }

    void Back()
    {
        SceneManager.LoadScene("MainMenuScene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}