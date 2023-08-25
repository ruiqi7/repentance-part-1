using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkThroughWalls : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    void Start()
    {
        transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector3.Distance(target.transform.position, transform.position) < 5) {
            Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            transform.position = new Vector3(newPos.x, 0, newPos.z);
            transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
        }
    }
}