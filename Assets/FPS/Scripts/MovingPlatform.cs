using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public float distance;

    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.Cos(Time.time * speed) * distance;
        transform.position = targetPosition + new Vector3(0, 0, movement);
    }
}
