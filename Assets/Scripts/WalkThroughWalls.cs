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
    private float startTime;
    private Vector3 targetPosition;
    void Start()
    {
        transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector3.Distance(target.transform.position, transform.position) < distance) {
            Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            transform.position = new Vector3(newPos.x, 0, newPos.z);
            transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
        } else if(Time.time - startTime >= 10) {
            transform.position = GetRandomTarget();
            startTime = Time.time;
            targetPosition = GetRandomTarget();
        } else {
            Vector3 newPos = Vector3.MoveTowards(transform.position, targetPosition, speed);
            transform.position = new Vector3(newPos.x, 0, newPos.z);
            transform.LookAt(targetPosition);
        }
    }

     private Vector3 GetRandomTarget() {
        return new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ,maxZ));
    }
}