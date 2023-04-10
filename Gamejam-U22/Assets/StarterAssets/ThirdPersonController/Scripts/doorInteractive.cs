using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class doorInteractive : MonoBehaviour
{

    public bool isInRange;
    public int keyValue = 0;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    public AudioSource source;
    public AudioClip clip;

    public Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    void Update()
    {
        keyValue = KeyInteractive.keyCount;

        if (Input.GetKeyDown(interactKey))
        {
            
            if (isInRange && keyValue >= 7)
            {
                interactAction.Invoke();
                source.PlayOneShot(clip);
                anim.SetTrigger("isClose");
                Debug.Log("E ye bastýn");
               
            }

            else if (isInRange && keyValue <= 6)
            {
                Debug.Log("Anahtar Eksik");
            }


        }


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Kafes alanýna girdi");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        isInRange = false;
        Debug.Log("Alandan çýktý");
    }
}
