using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayVolume : MonoBehaviour
{
    public TextMeshProUGUI songVolume;
    public float volumeCount;

    void Start()
    {
        
        songVolume = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        volumeCount = Mathf.Round(PlayerPrefs.GetFloat("volume") * 10f);
        if (volumeCount == 0f)
        {
            songVolume.text = "----------";
        }
        else if (volumeCount == 1f)
        {
            songVolume.text = " | ---------";
        }
        else if (volumeCount == 2f)
        {
            songVolume.text = " | | --------";
        }
        else if (volumeCount == 3f)
        {
            songVolume.text = " | | | -------";
        }
        else if (volumeCount == 4f)
        {
            songVolume.text = " | | | | ------";
        }
        else if (volumeCount == 5f)
        {
            songVolume.text = " | | | | | -----";
        }
        else if (volumeCount == 6f)
        {
            songVolume.text = " | | | | | | ----";
        }
        else if (volumeCount == 7f)
        {
            songVolume.text = " | | | | | | | ---";
        }
        else if (volumeCount == 8f)
        {
            songVolume.text = " | | | | | | | | --";
        }
        else if (volumeCount == 9f)
        {
            songVolume.text = " | | | | | | | | | -";
        }
        else if (volumeCount == 10f)
        {
            songVolume.text = " | | | | | | | | | | ";
        }

        if (volumeCount > 10)
        {
            volumeCount = 10;
        }
        else if (volumeCount < 0)
        {
            volumeCount = 0;
        }
    }
}
