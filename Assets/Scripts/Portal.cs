using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    private Transform destination;

    public bool isStart;
    public float distance = 0.2f;

    public string startName;

    public string endName;

    // Start is called before the first frame update
    void Start()
    {

        if (isStart == false) {
            destination = GameObject.FindGameObjectWithTag(startName).GetComponent<Transform>();
        } else {
            destination = GameObject.FindGameObjectWithTag(endName).GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (Vector2.Distance(transform.position, other.transform.position) > distance) {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }

}
