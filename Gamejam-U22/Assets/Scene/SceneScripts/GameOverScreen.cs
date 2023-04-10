using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text keysText;

    private void Update()
    {
        keysText.text = KeyInteractive.keyCount.ToString();
    }

}
