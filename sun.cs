using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour
{
    public float daylegth;
    public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
        rotationSpeed = Time.deltaTime / daylegth;
        transform.Rotate(0, rotationSpeed, 0);
        
    }
}
