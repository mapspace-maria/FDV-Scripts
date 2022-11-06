using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public  Vector3 target;
    public float accuracy;


    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        accuracy = 0.01f;

        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;


        Vector3 direction = target - transform.position;
       

        if(direction.magnitude > accuracy)
        {
            transform.Translate(direction.normalized * step, Space.World);
            
        }

    }

    }
