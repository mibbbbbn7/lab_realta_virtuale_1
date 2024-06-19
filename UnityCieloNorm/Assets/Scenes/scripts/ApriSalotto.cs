using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApriSalotto : MonoBehaviour
{
    public DoorController apritiSesamino;
    public ManigliaMove giraManiglia;
    public AudioSource DoorOpenSound;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            giraManiglia.ToggleManiglia();
            apritiSesamino.ToggleDoor();
            DoorOpenSound.Play();
        }
    }

    void OnTriggerExit(Collider collision)
    {
        giraManiglia.ToggleManiglia();
        apritiSesamino.ToggleDoor();
        DoorOpenSound.Play();
    }
}
