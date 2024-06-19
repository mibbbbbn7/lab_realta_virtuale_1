
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seduta : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public GameObject Messaggio;
    public bool Action = false;

    public PlayerMovement puoMuoversi;
    void Start()
    {
        camera2.enabled = false;
        Messaggio.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                CambioCamera();
            }
        }
    }

    void CambioCamera()
    {
        puoMuoversi.ToggleCanMove();
        camera1.enabled = !camera1.enabled;
        camera2.enabled = !camera2.enabled;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Messaggio.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Messaggio.SetActive(false);
        Action = false;
    }
}
