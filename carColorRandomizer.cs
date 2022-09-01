using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carColorRandomizer : MonoBehaviour
{
    public SpriteRenderer sprite;
    public float red;
    public float green;
    public float blue;
    public bool isColorRandom;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        red = Random.Range(0.25f, 1f);
        blue = Random.Range(0.25f, 1f);
        green = Random.Range(0.25f, 1f);

        if (isColorRandom == true)
        {
            
            if (blue > red && blue > green)
            {
                blue = 1f;
            }
            else if (blue < red && blue < green)
            {
                blue = 0.25f;
            }

            if (red > blue && red > green)
            {
                red = 1f;
            }
            else if (red < blue && red < green)
            {
                red = 0.25f;
            }

            if (green > red && green > blue)
            {
                green = 1f;
            }
            else if (green < red && green < blue)
            {
                green = 0.25f;
            }

            if (gameObject.tag == "Player")
            {
                sprite.color = new Color(red, blue, green, 1f);
            }
            else
            {
                sprite.color = new Color(Random.Range(0.25f, 1f), 0f, Random.Range(0.25f, 1f), 1f);
            }
        }
        else
        {
            if (gameObject.tag == "Player")
            {
                sprite.color = new Color(0f, 1f, 1f, 1f);
            }
            else
            {
                sprite.color = new Color(0.75f, 0.15f, 0.15f, 1f);
            }
        }

    }

}
