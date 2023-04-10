using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class firstStart : MonoBehaviour
{
    public Button startButton;
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("GirisEkraný");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
