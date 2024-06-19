using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destinazioneTeleport;
    public GameObject Playerz;

    private void OnTriggerEnter(Collider other)
    {
        Playerz.transform.position = destinazioneTeleport.transform.position;
    }
}
