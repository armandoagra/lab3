using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Camera cam;


    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.GetComponent<IInterativo>() != null)
            {
                if (Input.GetMouseButtonDown(0))
                    hit.collider.GetComponent<IInterativo>().Interagir();
                if (Input.GetMouseButtonDown(1))
                    hit.collider.GetComponent<IInterativo>().InteragirEspecial();
            }
        }

    }
}
