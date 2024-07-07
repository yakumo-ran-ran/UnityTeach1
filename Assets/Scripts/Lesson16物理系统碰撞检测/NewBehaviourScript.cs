using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int hp=3;

    private void OnTriggerEnter(Collider other)
    {
        hp--;
        if (hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
