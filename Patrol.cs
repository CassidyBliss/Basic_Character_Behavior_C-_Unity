using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultiple Component]
[RequireComponent(typeof(killable))]//attribute requiring component to be killable 

public class Patrol : MonoBehaviour
{
    [Tooltip("The distance this object moves forward before returning to start position")]

    public int dist;

    [RequireComponent(typeof(Killable))] //attribute requiring component to be killable
    public float speed;

    Vector3 startPos, endPos, targetPos ;

    private void Awake() 
    {
        startPos = transform.position;    
        endPos = startPos + transform.forward * dist;

    }
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, startPos) <= 0.1)
        {
            targetPos = endPos;
        }
        if(Vector3.Distance(transform.position, endPos) <= 0.1)
        {
            targetPos = startPos;
        }
        transform.position= Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
    }
}
