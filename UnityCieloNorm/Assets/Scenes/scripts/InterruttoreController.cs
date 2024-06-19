using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruttoreController : MonoBehaviour
{
    public GameObject interruttore;
    public float openRot, closeRot, speed;
    public bool opening;
    void Update()
    {
        Vector3 currentRot = interruttore.transform.localEulerAngles;
        if (opening)
        {
            if (currentRot.z < openRot)
            {
                interruttore.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, currentRot.y, openRot), speed * Time.deltaTime);
            }
        }
        else
        {
            if (currentRot.z > closeRot)
            {
                interruttore.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, currentRot.y, closeRot), speed * Time.deltaTime);
            }
        }
    }


    public void ToggleInterruttore()
    {
        opening = !opening;
    }
}
