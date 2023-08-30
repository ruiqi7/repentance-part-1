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
    private Animator animator;
    void Start()
    {
        transform.LookAt(target.transform.position);
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private Vector3 GetRandomTarget() {
        Vector3 newPos = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ,maxZ));
        transform.LookAt(new Vector3(newPos.x, 0, newPos.z));
        return newPos;
    }

    // Update is called once per frame
    void Update()
    {
        float normalisedSpeed = speed * (Time.time/300);
        RaycastHit hit;
        Vector3 direction = target.transform.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.yellow);
        if(Physics.Raycast(transform.position, direction, out hit)) {
            if(hit.collider.tag == "Wall") {
                moveRandom();
            } else if(hit.collider.tag == "Player") {
                Debug.Log("Found player");
                animator.SetBool("Chasing", true);
                Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, normalisedSpeed*2);
                rb.MovePosition(new Vector3(newPos.x, 0, newPos.z));
                transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
            } else {
                moveRandom();
            }
        } 
    }

    private void moveRandom() {
        float normalisedSpeed = speed * (Time.time/300);
        animator.SetBool("Chasing", false);
        if(Vector3.Distance(targetPosition, transform.position) <= 1) {
            Debug.Log("at position");
            targetPosition = GetRandomTarget();
        }
        RaycastHit hit;
        Vector3 direction = targetPosition - transform.position;
        Debug.DrawRay(transform.position, direction, Color.green);
        if(Physics.Raycast(transform.position, direction, out hit, 1.0f)) {
            if(hit.collider.tag == "Wall") {
                targetPosition = GetRandomTarget();
            }
        }
        Vector3 newPos = Vector3.MoveTowards(transform.position, targetPosition, normalisedSpeed);
        rb.MovePosition(new Vector3(newPos.x, 0, newPos.z));
    }
}
