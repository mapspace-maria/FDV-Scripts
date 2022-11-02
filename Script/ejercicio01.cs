using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public Vector3 goal;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,speed*Input.GetAxis("Vertical")*Time.deltaTime,0f);
    }
}
