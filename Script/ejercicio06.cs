using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public Vector3 goal;
    public float speed;
    public float accuracy = 0.05f;

        // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(goal);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal - transform.position;
        Debug.DrawRay(transform.position, direction, Color.green);
        if (direction.magnitude > accuracy)
        {
            transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,speed*Input.GetAxis("Vertical")*Time.deltaTime,0f) * direction.normalized;
        }
        
    }
}
