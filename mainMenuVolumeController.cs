using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuVolumeController : MonoBehaviour
{

    public AudioSource songPlayer;
    // Start is called before the first frame update
    void Start()
    {
        songPlayer = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("volume") == false)
        {
            PlayerPrefs.SetFloat("volume", songPlayer.volume);
        }
        else
        {
            songPlayer.volume = PlayerPrefs.GetFloat("volume");
        }
        songPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) == true)
        {
            songPlayer.volume = songPlayer.volume - 0.1f;
            PlayerPrefs.SetFloat("volume", songPlayer.volume);
        }
        else if (Input.GetKeyDown(KeyCode.X) == true)
        {
            songPlayer.volume = songPlayer.volume + 0.1f;
            PlayerPrefs.SetFloat("volume", songPlayer.volume);
        }
    }
}
