using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] GameObject spotLight;
    private bool isOn = false;

    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            isOn = !isOn;
            spotLight.SetActive(isOn);
            source.PlayOneShot(clip);

        }
    }
}