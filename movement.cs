using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float velocity;
    void Update()
    {
        if(Input.GetKey("w"))
        {
            gameObject.transform.Translate(0,0,velocity*Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            gameObject.transform.Translate(0,0,-velocity*Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            gameObject.transform.Translate(velocity*Time.deltaTime,0,0);
        }
        if(Input.GetKey("d"))
        {
            gameObject.transform.Translate(-velocity*Time.deltaTime,0,0);
        }
    }
}
