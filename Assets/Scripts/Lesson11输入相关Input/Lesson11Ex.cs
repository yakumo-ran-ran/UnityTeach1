using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11Ex : MonoBehaviour
{
    public float moveSpeed;

    public float rotateSpeed;

    public float headRotateSpeed;

    public Transform head;

    public Transform pkPos;
    public float pkRotateSpeed=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"),Space.Self);
        this.transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime,Input.GetAxis("Horizontal"),Space.Self);
        head.Rotate(Vector3.up*headRotateSpeed*Time.deltaTime*Input.GetAxis("Mouse X"),Space.Self);
        
        pkPos.Rotate(Vector3.right*rotateSpeed*Time.deltaTime*Input.mouseScrollDelta.y);
    }
}
