using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;
    // Start is called before the first frame update
    void Start()
    {
        print(this.transform.childCount);
        for (int i = 0; i < transform.childCount; i++)
        {
            print(transform.GetChild(i).name);
        }

        bool ischild= transform.IsChildOf(this.transform);
        print(ischild);
        print(son.GetSiblingIndex());
        son.SetAsFirstSibling();
        son.SetAsLastSibling();
        son.SetSiblingIndex(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
