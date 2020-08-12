using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_movement : MonoBehaviour
{
    public BoxCollider2D end;
    int[] randarray = new int[] { 1, 2, 3 };
    int rand;
    public float speed = -1.0f;

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector3(9.0f, 0.0f, 0.0f);
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(speed, 0.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 1.0f)
        {
            generateRandom();
            if (rand == 1)
            {
                lane1();
            }
            else if (rand == 2)
            {
                lane2();
            }
            else if (rand == 3)
            {
                lane3();
            }
        }
    }
        private void lane1()
        {
            if (gameObject.transform.position.x < -11.54)
            {
                gameObject.transform.position = new Vector3(9.0f, 3.28f, 0.0f);
            }
        }
        private void lane2()
        {
            if (gameObject.transform.position.x < -11.54)
            {
                gameObject.transform.position = new Vector3(9.0f, 0.0f, 0.0f);
            }
        }
        private void lane3()
        {
            if (gameObject.transform.position.x < -11.54)
            {
                gameObject.transform.position = new Vector3(9.0f, -3.32f, 0.0f);
            }
        }
        private void generateRandom()
        {
            rand = randarray[(int)Random.Range(0.0f, 3.0f)];
        }
}