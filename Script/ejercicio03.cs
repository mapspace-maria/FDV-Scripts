using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public Vector3 goal;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal - transform.position;
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,speed*Input.GetAxis("Vertical")*Time.deltaTime,0f) * direction.normalized;
    }
}
