using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingBackground : MonoBehaviour
{
    public float speed = 5;
    public float speedCof = 0.25f;

    public float endX;
    public float startX;
    private float length;
    void Start()
    {
        length = GetComponent<SpriteRenderer>().bounds.size.x * 2 - 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime * speedCof) ;

        if (transform.position.x <= endX)
        {
            transform.position = new Vector2(transform.position.x + length, transform.position.y);

        }
        speed = speed + Time.deltaTime;
    }
}
