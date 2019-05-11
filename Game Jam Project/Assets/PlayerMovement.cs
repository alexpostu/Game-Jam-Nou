using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float carSpeed = 1000000;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.position -= new Vector3(carSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("right"))
        {
            transform.position += new Vector3(carSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, carSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey("down")) {
            transform.position -= new Vector3(0, carSpeed * Time.deltaTime, 0);
        }
    }
}