using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothingObject : MonoBehaviour
{
    public GameObject pointOne;

    float timeElapsed = 0;
    float lerpDuration = 5;

    private Vector3 targetRotation;

    Quaternion endValue;

    private void Start()
    {
        targetRotation = new Vector3(82.45f, 244.81f, 344.33f);
        endValue = Quaternion.Euler(targetRotation);
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, endValue, 1f * Time.deltaTime);
    }
}
