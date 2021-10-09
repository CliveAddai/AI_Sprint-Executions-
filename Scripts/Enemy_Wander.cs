using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Wander : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float range = 2;
    public float maxDistance = 5;

    Vector2 wayPoint;

    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination();
        }

    }

    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }

}
