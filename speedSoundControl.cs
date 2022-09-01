using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedSoundControl : MonoBehaviour
{
    public float speed = 50;
    public float speedin100s;
    public AudioSource audioFile;

    // Start is called before the first frame update
    void Start()
    {
        audioFile = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        speed = speed + Time.deltaTime;
        speedin100s = speed * 0.01f;
        if (speedin100s <= 3)
        {
            audioFile.pitch = speedin100s;
        }
        else if (speedin100s > 3)
        {
            audioFile.pitch = 3;
        }
        
        
    }
}
