using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            _audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _audioSource.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!_audioSource.isPlaying)
            {
                _audioSource.UnPause();
                return;
            }
            _audioSource.Pause();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            _audioSource.UnPause();
        }
    }
}
