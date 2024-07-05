using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(this.transform.eulerAngles);
        print(this.transform.localEulerAngles);
        print(transform.localEulerAngles); 
        
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.Rotate(new Vector3(0,10*Time.deltaTime,0),Space.World);
        transform.Rotate(Vector3.right,10*Time.deltaTime,Space.World);
        transform.RotateAround(Vector3.zero,Vector3.right,10*Time.deltaTime);
    }
}
