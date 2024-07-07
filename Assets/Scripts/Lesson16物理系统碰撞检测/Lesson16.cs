using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    //碰撞相应函数
    private void OnCollisionEnter(Collision other)
    {
        // other.gameObject
        // other.transform
        // other.contactCount
        ContactPoint[] contactPoints= other.contacts;
        other.transform.GetComponent<Transform>();
        
        print(name+"被"+other.transform.name+"撞到了");
    }
    
    

    private void OnCollisionExit(Collision other)
    {
        print(name+"被"+other.transform.name+"Exit");
    }

    private void OnCollisionStay(Collision other)
    {
        print(name+"被"+other.transform.name+"Stay");
    }
    //Trigger
    protected virtual void OnTriggerEnter(Collider other)
    {
        print(name+"被"+other.transform.name+"Enter");

    }

    private void OnTriggerExit(Collider other)
    {
        print(name+"被"+other.transform.name+"Exit");

    }

    private void OnTriggerStay(Collider other)
    {
        print(name+"被"+other.transform.name+"Stay");

    }
}
