using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AccendiCucina : MonoBehaviour
{
    public Light luce1;
    public Light luce2;
    public Light luce3;
    public Light luce4;
    public Light luce5;
    public GameObject Instruction;
    public InterruttoreControllerCucina interruttore1;
    public AudioSource PigiaInterruttore;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);
        luce1.enabled = false;
        luce2.enabled = false;
        luce3.enabled = false;
        luce4.enabled = false;
        luce5.enabled = false;
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
                luce4.enabled = !luce4.enabled;
                luce5.enabled = !luce5.enabled;
                interruttore1.ToggleInterruttore();
                PigiaInterruttore.Play();
            }
        }

    }
}

