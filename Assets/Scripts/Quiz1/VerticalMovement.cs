using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.up * Input.GetAxis("Vertical");
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
