﻿using UnityEngine;

public class Rotate : MonoBehaviour {

    public float speed = 100f;

    void Update ()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);






    }
}
