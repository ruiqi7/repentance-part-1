using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    // Start is called before the first frame update
    public int interactDistance = 2;
    void Start()
    {
        
    }

    // Update is called once per 
    void Update()
    {
        // Creates a Ray from the center of the viewport
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(ray.origin, ray.direction * 10);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactDistance)) {
            if (hit.collider.CompareTag("Interactable")) { 
                GameObject interact = hit.transform.gameObject;
                //interact.transform.position += Vector3.forward * 1f;
                if (Input.GetKeyDown(KeyCode.E)) {
                    interact.transform.position += Vector3.forward * 1f;
                }
                Debug.Log("Object hit");
            }
        }
    }
}
