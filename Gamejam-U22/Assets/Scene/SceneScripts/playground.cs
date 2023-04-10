using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class playground : MonoBehaviour
{
    public Button tryAgainButton;
    void Start()
    {
        tryAgainButton.onClick.AddListener(TryAgain);
    }

    void TryAgain()
    {
        SceneManager.LoadScene("Playground");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
