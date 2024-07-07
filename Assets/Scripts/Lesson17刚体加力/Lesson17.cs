using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(this.transform.forward*10); 
        // rigidBody.AddRelativeForce(Vector3.forward*10);
        // rigidBody.AddTorque(this.transform.up*10);
        // rigidBody.AddRelativeTorque(Vector3.up*10);
        // rigidBody.velocity = Vector3.forward * 5;

        // rigidBody.AddExplosionForce(100,Vector3.zero,10);


    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
