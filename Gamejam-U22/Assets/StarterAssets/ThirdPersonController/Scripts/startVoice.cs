using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startVoice : MonoBehaviour
{
    public int indexValue;
    public AudioSource source;
    public AudioClip clip;
    public float delay;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        indexValue = girisEkraný.index;

        if (indexValue == 5 )
        {
            source.PlayOneShot(clip);
            StartCoroutine(CloseCoroutine());
            if (!GetComponent<AudioSource>().isPlaying)
            {
                SceneManager.LoadScene("Playground");
            }
        }



    }
    IEnumerator CloseCoroutine()
    {
        yield return new WaitForSeconds(delay);
        source.Stop();
        source.enabled = false;
    }


}
