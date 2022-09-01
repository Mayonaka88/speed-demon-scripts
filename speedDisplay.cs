using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class speedDisplay : MonoBehaviour
{
    public GameObject ground;
    public repeatingBackground speed;
    public TextMeshProUGUI textSpeed;

    void Start()
    {
        speed = ground.GetComponent<repeatingBackground>();
        textSpeed = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textSpeed.text = Mathf.Round(speed.speed).ToString() + " KM/H";
        PlayerPrefs.SetInt("CurrentScore", Mathf.RoundToInt(speed.speed));
    }
}
