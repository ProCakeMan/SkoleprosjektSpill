using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulbEndScene : MonoBehaviour
{
    Light lt;

    public float maxIntens = 1f;

    public float minIntens = 0f;

    public float flickerSpeed = 0.1f;

    private void Start()
    {
        lt = GetComponent<Light>();
    }

    void Update()
    {
        lt.intensity = Mathf.Lerp(minIntens, maxIntens, Mathf.PingPong(Time.time, flickerSpeed));
        lt.intensity = lt.intensity * 5;
    }
}
