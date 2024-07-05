using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;

        Vector3 v2 = new Vector3(10, 10, 10);

        Vector3 v1 = new Vector3(1, 1, 1);
        Vector3 v3 = new Vector3(3, 3, 3);
        //
        // print(v1+v3);
        // print(v1-v3);
        // print(v1*10);
        // print(v3/2);
        print(Vector3.zero);//000
        print(Vector3.right);//100
        print(Vector3.left);//-100
        print(Vector3.forward);//001
        print(Vector3.back);//00-1
        print(Vector3.up);//010;
        print(Vector3.down);//0-10
        
        print(Vector3.Distance(v1,v3));

        // this.gameObject.transform.position;
        //世界坐标系位置
        print(this.transform.position);
        print(this.transform.localPosition);

        transform.position = new Vector3(1, 1, 1);
        transform.localPosition=Vector3.up*10;
        transform.position = new Vector3(19, transform.position.y, transform.position.z);

        Vector3 vPos = transform.localPosition;
        vPos.x = 10;
        transform.localPosition = vPos;
        
        
        print(transform.forward);
        print(transform.right);
        print(transform.up);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * 1f, Space.Self);
    }
}
