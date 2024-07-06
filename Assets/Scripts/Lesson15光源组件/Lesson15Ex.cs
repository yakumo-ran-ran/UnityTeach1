using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15Ex : MonoBehaviour
{
    public Light light;

    public float moveSpeed=10;

    public float flashSpeed=10;


    public Transform lightTransform;

    public float rotateSpeed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.transform.Translate(Vector3.right*moveSpeed*Time.deltaTime);
        if (light.transform.position.x >= 1)
            moveSpeed = -moveSpeed;
        else if (light.transform.position.x<0.8)
        {
            moveSpeed = -moveSpeed;
        }

        light.intensity += flashSpeed * Time.deltaTime;
        if (light.intensity>=1)
        {
            flashSpeed = -flashSpeed;
        }
        else if (light.intensity<=0.5)
        {
            flashSpeed = -flashSpeed;
        }
        lightTransform.Rotate(Vector3.right*Time.deltaTime*rotateSpeed);
    }
}
