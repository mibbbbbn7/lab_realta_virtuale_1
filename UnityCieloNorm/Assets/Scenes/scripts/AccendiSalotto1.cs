using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AccendiSalotto1 : MonoBehaviour
{
    public Light luce1;
    public Light luce2;
    public Light luce3;
    public GameObject Instruction;
    public InterruttoreController interruttore1;
    public AudioSource PigiaInterruttore;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);
        luce1.enabled = false;
        luce2.enabled = false;
        luce3.enabled = false;
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Action == true)
            {
                luce1.enabled = !luce1.enabled;
                luce2.enabled = !luce2.enabled;
                luce3.enabled = !luce3.enabled;
                interruttore1.ToggleInterruttore();
                PigiaInterruttore.Play();
            }
        }

    }
}

