using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songRandomizor : MonoBehaviour
{
    public AudioClip songChanging;
    public AudioClip[] songs;
    public AudioClip[] RFtracks;
    public AudioSource songPlayer;

    // Start is called before the first frame update
    void Start()
    {
        songPlayer = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("RS") == 0)
        {
            songPlayer.clip = songs[Random.Range(0, songs.Length)];
        }
        else if (PlayerPrefs.GetInt("RS") == 1)
        {
            songPlayer.clip = RFtracks[Random.Range(0, RFtracks.Length)];
        }

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

        if (Input.GetKeyDown(KeyCode.C) == true)
        {
            songPlayer.Stop();
            StartCoroutine(changeSong());
        }

    }

    IEnumerator changeSong()
    {
        songPlayer.clip = songChanging;
        songPlayer.Play();
        yield return new WaitForSeconds(1f);
        songPlayer.Stop();

        if (PlayerPrefs.GetInt("RS") == 0)
        {
            songPlayer.clip = songs[Random.Range(0, songs.Length)];
        }
        else
        {
            songPlayer.clip = RFtracks[Random.Range(0, RFtracks.Length)];
        }

        songPlayer.Play();

    }

}
