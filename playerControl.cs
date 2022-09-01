using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControl : MonoBehaviour
{
    public Vector2 playerLocation;
    public float yNewDistance;
    public float speed;
    public int health;

    public float startTime;
    public float timeSinceStartOfScene;

    public float maxHeight;
    public float minHeight;

    public Vector2 fixedMax;
    public Vector2 fixedMin;


    // Start is called before the first frame update
    void Start()
    {
        playerLocation = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, playerLocation, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            playerLocation = new Vector2(transform.position.x, transform.position.y + yNewDistance);
            StartCoroutine(turn(-65));

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            playerLocation = new Vector2(transform.position.x, transform.position.y - yNewDistance);
            StartCoroutine(turn(-115));
            
        }

        if (transform.position.y > maxHeight)
        {
            playerLocation = fixedMax;
            transform.eulerAngles = new Vector3(0,0,-90);


        }
        else if (transform.position.y < minHeight)
        {
            playerLocation = fixedMin;
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        else if (transform.position.y == 0.5 || transform.position.y == -0.5)
        {
            //transform.position = new Vector3(0,0,0);
            playerLocation = new Vector3(0, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, -90);
        }

    }

    IEnumerator turn(int angle)
    {
        transform.eulerAngles = new Vector3(0, 0, angle);

        yield return new WaitForSeconds(0.1f);

        transform.eulerAngles = new Vector3(0, 0, -90);
    }

}
