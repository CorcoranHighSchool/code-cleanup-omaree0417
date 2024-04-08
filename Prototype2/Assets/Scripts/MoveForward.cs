﻿using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeFieldprivate float speed = 40.0f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
