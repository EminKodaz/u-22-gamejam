using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class goToContoller : MonoBehaviour
{
    public Button controllerButton;
    void Start()
    {
        controllerButton.onClick.AddListener(Controls);
    }

    void Controls()
    {
        SceneManager.LoadScene("KontrollerScene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}