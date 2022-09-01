using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class policeLights : MonoBehaviour
{
    public Light2D lightingProp;
    public Vector2 lightLocation;
    public float speed;
    public float yNewDistance;

    public float maxHeight;
    public float minHeight;

    public float fixedMax;
    public float fixedMin;

    public float timing;
    public bool timingHelp;

    // Update is called once per frame

    private void Start()
    {
        lightingProp = GetComponent<Light2D>();
        timing = Random.Range(1f, 2f);

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, lightLocation, speed * Time.deltaTime);

        if (timing >= 2)
        {
            timingHelp = false;
        }
        else if (timing <= 1)
        {
            timingHelp = true;
        }

        if (timingHelp == true)
        {
            timing = timing + Time.deltaTime + 0.1f;
        }

        else if(timingHelp == false){
            timing = timing - Time.deltaTime - 0.1f;
        }

        lightingProp.intensity = timing;

        if (transform.position.y >= maxHeight)
        {
            lightLocation = new Vector2(transform.position.x, fixedMin);
        }
        else if (transform.position.y <= minHeight)
        {
            lightLocation = new Vector2(transform.position.x, fixedMax);

        }
    }
}
