using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displaySong : MonoBehaviour
{
    public GameObject backgroundMusic;
    public AudioSource song;
    public TextMeshProUGUI songName;
    public bool RFTracksOnOff;
    public bool isSongChanging;

    void Start()
    {
        song = backgroundMusic.GetComponent<AudioSource>();
        songName = GetComponent<TextMeshProUGUI>();
        if (PlayerPrefs.GetInt("RS") == 0)
        {
            RFTracksOnOff = false;
        }
        else if (PlayerPrefs.GetInt("RS") == 1)
        {
            RFTracksOnOff = true;
        }

    }

    private void Update()
    {

        if (isSongChanging == false)
        {
            if (RFTracksOnOff == true)
            {
                songName.text = "Now Playing: " + song.clip.name + ".mp3";
            }
            else
            {
                songName.text = "Now Playing: " + song.clip.name;
            }
        }

        if (Input.GetKeyDown(KeyCode.C) == true)
        {
            StartCoroutine(changeSong());
        }
    }

    IEnumerator changeSong()
    {
        isSongChanging = true;
        songName.text = "djbfksjdbfjklsdbhfdjbfksjdbfjklsdbhf";
        yield return new WaitForSeconds(0.1f);
        songName.text = "823yur923hyr8u9j5489djerfherhertherhtrher";
        yield return new WaitForSeconds(0.1f);
        songName.text = "erfherhertherhtrhernjbnnghjghjygjgjhjg";
        yield return new WaitForSeconds(0.1f);
        songName.text = "njbnnghjghjygjgjhjgerfherhertherhtrher";
        yield return new WaitForSeconds(0.1f);
        songName.text = "34234t23t435b3b53b5434234t23t435b3b53b54";
        yield return new WaitForSeconds(0.1f);
        songName.text = "djbfksjdbfjklsdbhfdjbfksjdbfjklsdbhf";
        yield return new WaitForSeconds(0.1f);
        songName.text = "823yur923hyr8u9j5489djerfherhertherhtrher";
        yield return new WaitForSeconds(0.1f);
        songName.text = "erfherhertherhtrhernjbnnghjghjygjgjhjg";
        yield return new WaitForSeconds(0.1f);
        songName.text = "njbnnghjghjygjgjhjgerfherhertherhtrher";
        yield return new WaitForSeconds(0.1f);
        songName.text = "34234t23t435b3b53b5434234t23t435b3b53b54";
        yield return new WaitForSeconds(0.1f);

        if (PlayerPrefs.GetInt("RS") == 0)
        {
            RFTracksOnOff = false;
        }
        else if (PlayerPrefs.GetInt("RS") == 1)
        {
            RFTracksOnOff = true;
        }

        isSongChanging = false;

    }
}
