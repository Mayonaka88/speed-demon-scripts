using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstical : MonoBehaviour
{
    public int damage = 1;
    public float speedofMovement;
    public float speedCof;
    public AudioClip sound;
    public AudioSource soundPlayer;

    void Start()
    {
        soundPlayer = GetComponent<AudioSource>();

    }

    void Update()
    {
        transform.Translate(Vector2.left * speedofMovement * Time.deltaTime);
        speedofMovement = speedofMovement + (Time.timeSinceLevelLoad + 5) * speedCof;

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            soundPlayer.clip = sound;
            soundPlayer.Play();
            setScore(Mathf.RoundToInt(PlayerPrefs.GetInt("CurrentScore")));
            SceneManager.LoadScene("Death Screen");

            other.GetComponent<playerControl>().health -= damage;
            Destroy(gameObject);
        }


    }
    public void setScore(int currentScore)
    {
        
        if (PlayerPrefs.HasKey("HighScore") == true)
        {
            if (currentScore > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
    }

}
