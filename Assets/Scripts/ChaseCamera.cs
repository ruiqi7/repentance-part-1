using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    void Start()
    {
        transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        transform.position = new Vector3(newPos.x, 0, newPos.z);
        transform.LookAt(target.transform.position);
    }
}
