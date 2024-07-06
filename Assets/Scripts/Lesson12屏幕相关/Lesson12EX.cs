using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12EX : MonoBehaviour
{

    public Transform target;

    public float roundSpeed=50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(target.position,Vector3.up,roundSpeed*Time.deltaTime*Input.GetAxis("Mouse X"));
        }
    }
}
