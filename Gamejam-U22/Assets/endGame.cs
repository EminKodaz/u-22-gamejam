using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public bool isInRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange) 
        {
            SceneManager.LoadScene("WonScene");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Alana Girdi");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        isInRange = false;
        Debug.Log("Alandan çýktý");
    }
}
