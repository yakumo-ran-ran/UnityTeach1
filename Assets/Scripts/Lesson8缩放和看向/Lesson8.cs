 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(transform.lossyScale);
        print(transform.localScale);
        transform.localScale = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.localScale+=Vector3.one*Time.deltaTime;
        transform.LookAt(Vector3.zero);

    }
}
