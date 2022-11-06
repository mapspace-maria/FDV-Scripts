using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject Player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
    }
}
