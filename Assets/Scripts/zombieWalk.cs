using UnityEngine;
using System.Collections;

public class ZombieWalk : MonoBehaviour
{
    [SerializeField] private float minX, maxX;
    [SerializeField] private float minZ, maxZ;
    [SerializeField] private float speed;

    private Vector3 targetPosition;

    private Vector3 GetRandomTarget() {
        return new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ,maxZ));
    }

    void Start() {
        targetPosition = GetRandomTarget();
        transform.LookAt(targetPosition);
        StartCoroutine(NextLoc());
    }

    IEnumerator NextLoc() {
        yield return new WaitForSeconds(3);
        targetPosition = GetRandomTarget();
        transform.LookAt(targetPosition);
        StartCoroutine(NextLoc());
    }
    private void Update() {
        Vector3 newPos = Vector3.MoveTowards(transform.position, targetPosition, speed);
        transform.position = new Vector3(newPos.x, 0, newPos.z);
    }
}