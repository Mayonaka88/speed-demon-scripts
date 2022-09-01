using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreDisplay : MonoBehaviour
{
    public bool isHighScore;
    public TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();

        if (isHighScore == true)
        {
            textScore.text = PlayerPrefs.GetInt("HighScore").ToString() + " KM/H";
        }
        else
        {
            textScore.text = PlayerPrefs.GetInt("CurrentScore").ToString() + " KM/H";
        }
    }

}
