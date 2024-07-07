using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson21 : MonoBehaviour
{
    private AudioClip AudioClip;
    // Start is called before the first frame update
    void Start()
    {
        string[] mcs = Microphone.devices;
        for (int i = 0; i < mcs.Length; i++)
        {
            print(mcs[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            AudioClip= Microphone.Start("阵列麦克风 (AMD Audio Device)", false, 10,44100);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        { 
            Microphone.End("阵列麦克风 (AMD Audio Device)");
            AudioSource s = GetComponent<AudioSource>();
            if (s == null)
                s=this.AddComponent<AudioSource>();
            s.clip = AudioClip;
            s.Play();
        }
    }
}
