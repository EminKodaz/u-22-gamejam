using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeeAlert : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            
            SceneManager.LoadScene("GameOverScene");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
