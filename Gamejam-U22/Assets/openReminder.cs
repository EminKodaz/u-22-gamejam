using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openReminder : MonoBehaviour
{
    public GameObject canvasText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            canvasText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasText.SetActive(false);
        }
    }
}
