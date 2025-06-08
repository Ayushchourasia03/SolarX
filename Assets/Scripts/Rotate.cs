using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Around the first parameter is target position
        //second parameter is axis of rotation
        //third parameter is speed of rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
