using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObj : MonoBehaviour
{
    public float moveSpeed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.CompareTag("Ground"))
    //     {
    //         Destroy(gameObject);
    //     }
    //     
    // }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
