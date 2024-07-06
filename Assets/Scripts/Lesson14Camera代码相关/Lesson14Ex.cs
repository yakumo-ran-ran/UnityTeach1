using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Camera.main.WorldToScreenPoint(transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = Input.mousePosition;
            v.z = 20;
            obj.transform.position = Camera.main.ScreenToWorldPoint(v);
        }
    }
}
