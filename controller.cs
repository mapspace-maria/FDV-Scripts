using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Event;

public class controller : MonoBehaviour,IBegininDragHandler,IDraghandler
{

    //public Vector3 goal;
    public float speed;
    public void AddDefaultEvent();
    private void AddEvenByScript(GameObject Go);

    [SerializeField]
    private unityEvent _myUnityEvent;


    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,speed*Input.GetAxis("Vertical")*Time.deltaTime,0f);
        
        

    //Trying different events Trigger - not part of the assignment. Just my curiousity
        if(Go.GetComponent<EventTrigger>() == null)
        {
            Go.AddComponent<EventTrigger>();
        }
        EventTrigger trigger = Go.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((thefunction) => { AddDefaultEvent(); });
        trigger.triggers.Add(entry);

    }
}
