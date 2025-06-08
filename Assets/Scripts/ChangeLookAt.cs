using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeLookAt : MonoBehaviour
{
    //declare a gameObject variable which define where the camera should look at
    public GameObject target;
    public INFO obj;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
        }
    }

    private void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
        Debug.Log(target.tag);
        obj.changeValues(target.tag);
    }
}
