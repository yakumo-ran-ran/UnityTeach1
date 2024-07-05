using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7Ex : MonoBehaviour
{
    public float rotateSpeed=10;
    public float headRotateSpeed=10;
    public float posRotateSpeed=10;
    public Transform head;

    public Transform pos;

    public Transform dq;

    public Transform ty;

    public Transform yl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up,rotateSpeed*Time.deltaTime);
        head.Rotate(Vector3.up,headRotateSpeed*Time.deltaTime);
        pos.Rotate(Vector3.right,posRotateSpeed*Time.deltaTime);
        print(head.localEulerAngles.y);
        if (!(head.localEulerAngles.y>=315&&head.localEulerAngles.y<360f)
            &&head.localEulerAngles.y >= 45f && headRotateSpeed > 0)
            headRotateSpeed = -headRotateSpeed;
        else if (!(head.localEulerAngles.y>0&&head.localEulerAngles.y<45f)
                 &&head.localEulerAngles.y<=315f&& headRotateSpeed<0)
            headRotateSpeed = -headRotateSpeed;
        
        if (!(pos.localEulerAngles.x>=350&&pos.localEulerAngles.x<360f)
            &&pos.localEulerAngles.x >= 10f && headRotateSpeed > 0)
            posRotateSpeed = -posRotateSpeed;
        else if (!(pos.localEulerAngles.x>0&&pos.localEulerAngles.x<10f)
                 &&pos.localEulerAngles.x<=350&& headRotateSpeed<0)
            posRotateSpeed = -posRotateSpeed;
        
        ty.Rotate(Vector3.up,10*Time.deltaTime);
        dq.Rotate(Vector3.up,10*Time.deltaTime);
        yl.Rotate(Vector3.up,10*Time.deltaTime);
        
        dq.RotateAround(ty.position,Vector3.up,10*Time.deltaTime);
    }
}
