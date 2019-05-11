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
        if (Input.GetKeyDown("left"))
        {
            transform.position -= new Vector3(carSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.position += new Vector3(carSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("up"))
        {
            transform.position += new Vector3(0, carSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.position -= new Vector3(0, carSpeed * Time.deltaTime, 0);
        }
    }
}
