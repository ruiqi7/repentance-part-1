using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    private Rigidbody rb;
    void Start()
    {
        transform.LookAt(target.transform.position);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 direction = Camera.main.transform.position - transform.position;
        Debug.DrawRay(transform.position, direction);
        if(Physics.Raycast(transform.position, direction, out hit)) {
            if(hit.collider.CompareTag("MainCamera")) {
                Debug.Log("hello");
                Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed);
                rb.MovePosition(new Vector3(newPos.x, 0, newPos.z));
                transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
            }
        }
        // if(Vector3.Distance(target.transform.position, transform.position) < 5) {
        //     Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        //     rb.MovePosition(new Vector3(newPos.x, 0, newPos.z));
        //     transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
        // }
    }
}
