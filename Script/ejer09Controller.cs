using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public  Vector3 target;
    public float speedrotation;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        

        transform.Translate(Input.GetAxis("Horizontal")*step, 0f, Input.GetAxis("Vertical")* step);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + 1f;
        }

        var step02 = speedrotation * Time.deltaTime;

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        }
    }


    }