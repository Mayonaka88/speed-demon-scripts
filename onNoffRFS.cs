using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onNoffRFS : MonoBehaviour
{
    public TextMeshProUGUI toggle;

    void Start()
    {
        if (PlayerPrefs.HasKey("RS") == false)
        {
            PlayerPrefs.SetInt("RS", 0);
        }

        toggle = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("RS") == 0)
        {
            toggle.color = new Color(0f,0f,0f);
        }
        else if (PlayerPrefs.GetInt("RS") == 1)
        {
            toggle.color = new Color(0f, 1f, 1f);
        }
    }
}
