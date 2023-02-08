using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpetMovement : MonoBehaviour
{
    float horiz;
    float vert;
    float speed = 9.0f;
    float force;
    [SerializeField] Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = speed * 100;
    }

    // Update is called once per frame
    void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horiz, 0, vert) * force * Time.deltaTime;
    }
}
