using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public Text s;   
    public static int score = 0;
    public Rigidbody2D car;
    public Rigidbody2D obstacle;
    public float side = 10.0f;
    Vector3 speed;
    public float temp = 0.00001f;

    // Use this for initialization
    void Start()
    {
        car = gameObject.GetComponent<Rigidbody2D>();
        speed = new Vector3(0, side, 0);
        gameObject.transform.position = new Vector3(-5.7f, 0.0f, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 1.0f)
        {
            if (car.IsTouching(obstacle.GetComponent<Collider2D>()))
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                if (Input.GetKey(KeyCode.UpArrow))
                    car.AddForce(speed);
                if (Input.GetKey(KeyCode.DownArrow))
                    car.AddForce(new Vector3(0, -side, 0));
                if (Input.GetKey(KeyCode.UpArrow))
                    car.AddForce(new Vector3(0, side + 10.0f, 0));
                if (Input.GetKey(KeyCode.DownArrow))
                    car.AddForce(new Vector3(0, -side - 10.0f, 0));
                score = (int)Time.time;
                s.text = "Score : " + score;
            }
        }
        else if(car.transform.position.x < -5.7f)
        {
            gameObject.transform.Translate(temp, 0.0f, 0.0f);
        }
    }
}
