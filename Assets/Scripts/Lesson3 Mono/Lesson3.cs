using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        Lesson3Test[] arrayParent = GetComponentsInParent<Lesson3Test>();
        print(arrayParent.Length);
        arrayParent = GetComponentsInChildren<Lesson3Test>();
        print(arrayParent.Length);
        Lesson3Test lesson3Test;
        this.TryGetComponent<Lesson3Test>(out lesson3Test);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
