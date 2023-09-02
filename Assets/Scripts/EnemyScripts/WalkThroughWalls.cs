using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkThroughWalls : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    [SerializeField] private float minX, maxX;
    [SerializeField] private float minZ, maxZ;
    private Animator animator;
    private float startTime;
    private Vector3 targetPosition;
    void Start()
    {
        transform.LookAt(target.transform.position);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float normalisedSpeed = speed * (Time.time/300);
        if(Vector3.Distance(target.transform.position, transform.position) < distance) {
            animator.SetBool("Chasing", true);
            Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, normalisedSpeed*2);
            transform.position = new Vector3(newPos.x,transform.position.y, newPos.z);
            transform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
        } else if(Time.time - startTime >= 10) {
            animator.SetBool("Chasing", false);
            transform.position = GetRandomTarget();
            startTime = Time.time;
            targetPosition = GetRandomTarget();
        } else {
            animator.SetBool("Chasing", false);
            Vector3 newPos = Vector3.MoveTowards(transform.position, targetPosition, normalisedSpeed);
            transform.position = new Vector3(newPos.x, transform.position.y, newPos.z);
            transform.LookAt(targetPosition);
        }
    }

     private Vector3 GetRandomTarget() {
        return new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minZ,maxZ));
    }
}