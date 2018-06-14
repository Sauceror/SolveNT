
using UnityEngine;
using System.Collections;

public class Respawn2 : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(-6, 0 , 0);
    }
}