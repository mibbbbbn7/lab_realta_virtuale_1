using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManigliaMove : MonoBehaviour
{
    public GameObject maniglia;
    public float openRot, closeRot, speed;
    public bool opening;
    void Update()
    {
        Vector3 currentRot = maniglia.transform.localEulerAngles;
        if (opening)
        {
            if (currentRot.x < openRot)
            {
                maniglia.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(openRot, currentRot.y, currentRot.z), speed * Time.deltaTime);
            }
        }
        else
        {
            if (currentRot.x > closeRot)
            {
                maniglia.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(closeRot, currentRot.y, currentRot.z), speed * Time.deltaTime);
            }
        }
    }


    public void ToggleManiglia()
    {
        opening = !opening;
    }
}