using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("左前方创建物体")]
    void TestFun1()
    {
        Vector3 pos = this.transform.TransformPoint(new Vector3(-1, 0, 1));
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.position = pos;
    }

    [ContextMenu("创建三个球体")]
    void TestFun2()
    {
        
        for (int i = 1; i <= 3; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            obj.transform.position = this.transform.TransformPoint(i*Vector3.forward);
        }
    }
}
