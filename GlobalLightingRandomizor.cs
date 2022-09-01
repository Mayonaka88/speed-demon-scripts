using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GlobalLightingRandomizor : MonoBehaviour
{
    public Light2D globalLight;
    public float red;
    public float green;
    public float blue;
    public float redOrBlue;
    // Start is called before the first frame update
    void Start()
    {
        redOrBlue = Random.Range(0f,1f);
        globalLight = GetComponent<Light2D>();
        if (redOrBlue >= 0.5f)
        {
            red = 0.075f;
            green = 0f;
            blue = 0.25f;
            globalLight.color = new Color(red, green, blue, 1f);
        }
        else
        {
            red = 0.25f;
            green = 0f;
            blue = 0f;
            globalLight.color = new Color(red, green, blue, 1f);
        }
        
    }

}
