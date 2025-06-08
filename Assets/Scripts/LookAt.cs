using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LookAt : MonoBehaviour
{
   

    //target that the camera should look at
    [SerializeField] static public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target= this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
    }
    
}
