using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private float minX, maxX;
    [SerializeField] private float minZ, maxZ;
    private Rigidbody rb;
    private Vector3 targetPosition;
    void Start()
    {
        transform.LookAt(target.transform.position);
        rb = GetComponent<Rigidbody>();
    }

    private Vector3 GetRandomTarget() {
        return new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ,maxZ));
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 direction = Camera.main.transform.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.yellow);
        if(Physics.Raycast(transform.position, direction, out hit)) {
            if(hit.collider.tag == "Wall") {
            } else if(hit.collider.tag == "MainCamera") {
                Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed);
                rb.MovePosition(new Vector3(newPos.x, 0, newPos.z));
                transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
            }
        }
    }
}
