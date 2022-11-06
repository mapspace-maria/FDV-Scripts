using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public  Vector3 target;


    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        transform.Translate(target.normalized * step);

    }

    }

