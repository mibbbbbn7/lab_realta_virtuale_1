using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ApriVetro : MonoBehaviour
{
    public DoorController apritiSesamo;
    public GameObject Instruction;
    public AudioSource DoorOpenSound;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                apritiSesamo.ToggleDoor();
                DoorOpenSound.Play();
            }
        }

    }
}
