using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Vector3.forward);
        print("转换后的点"+this.transform.InverseTransformPoint(Vector3.forward));
        
        print("转换后的方向"+this.transform.InverseTransformDirection(Vector3.forward));
        print("受缩放后的影响转换后的方向"+this.transform.InverseTransformVector(Vector3.forward));
        
        print("本地转世界点"+this.transform.TransformPoint(Vector3.forward));
        print("本地转世界方向"+this.transform.TransformDirection(Vector3.forward));
        print("本地转世界方向(受缩放影响)"+this.transform.TransformVector(Vector3.forward));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
