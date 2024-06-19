using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruttoreControllerCucina : MonoBehaviour
{
    public GameObject interruttore;
    public float openRot, closeRot, speed;
    public bool opening;
    void Update()
    {
        Vector3 currentRot = interruttore.transform.localEulerAngles;
        if (opening)
        {
            if (currentRot.x < openRot)
            {
                interruttore.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(openRot, currentRot.y, currentRot.z), speed * Time.deltaTime);
            }
        }
        else
        {
            if (currentRot.x > closeRot)
            {
                interruttore.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(closeRot, currentRot.y, currentRot.z ), speed * Time.deltaTime);
            }
        }
    }


    public void ToggleInterruttore()
    {
        opening = !opening;
    }
}
