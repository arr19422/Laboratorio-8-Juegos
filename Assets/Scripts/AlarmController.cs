using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmController : MonoBehaviour
{

    private Light light;
    private bool player = false;
    float duration = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            float t = Mathf.PingPong(Time.time * 4, duration);
            
            light.intensity = t;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player = true;
    }

    private void OnTriggerExit(Collider other)
    {
        player = false;
        light.intensity = 0;
    }
}
