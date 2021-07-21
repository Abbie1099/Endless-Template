using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 20.0f;
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
