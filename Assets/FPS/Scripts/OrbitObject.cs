using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitObject : MonoBehaviour
{
    public GameObject target;
    public Vector2 frequency = Vector2.one;
    public Vector2 distance = Vector2.one;
    public float heightOffset;

    private Vector3 targetPosition;

    void Start()
    {
    }

    void Update()
    {
        ApplyMovement();
        ApplyRotation();
    }

    void ApplyMovement()
    {
        targetPosition = target.transform.position;
        float movementInX = Mathf.Sin(Time.time * frequency.x) * distance.x;
        float movementInY = Mathf.Cos(Time.time * frequency.y) * distance.y;
        transform.position = targetPosition + new Vector3(movementInX, heightOffset, movementInY);

    }

    void ApplyRotation()
    {
        transform.Rotate(0, Time.deltaTime, 0, Space.Self);
    }
}
