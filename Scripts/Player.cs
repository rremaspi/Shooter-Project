using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // its access level: public or private
    // its type: int (5, 8, 36, etc.), float (2.5f, 3.7f, etc.)
    // its name: speed, playerSpeed --- Speed, PlayerSpeed
    // optional: give it an initial value
    private float speed;
    private int lives = 3;
    private int score = 0;
    private float horizontalInput;
    private float verticalInput;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        if (transform.position.y > 0)
       {
        transform.position = new Vector3(transform.position.x, -0.001f, 0);
       }

       if (transform.position.y < -4)
       {
        transform.position = new Vector3(transform.position.x, -3.99f, 0);
       }

        if (transform.position.x > 9.3f)
        {
            transform.position = new Vector3(9.299f, transform.position.y, 0);
        }

         if (transform.position.x < -9.3f)
        {
            transform.position = new Vector3(-9.299f, transform.position.y, 0);
        }
    }

    void Shooting()
    {
        //if I press SPACE
        //Create a bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Create a bullet
            Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

}