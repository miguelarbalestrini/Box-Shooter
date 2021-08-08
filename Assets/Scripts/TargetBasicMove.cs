using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBasicMove : MonoBehaviour
{
    [SerializeField]
    float spinSpeed;
    [SerializeField]
    float motionMagnitude;
    [SerializeField]
    bool doSpin = false;
    [SerializeField]
    bool doMotion = false;
    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (doMotion)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }   
    }
}
