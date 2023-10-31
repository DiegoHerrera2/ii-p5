using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderC : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpForce;

    private float timeCounter;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;

        if (timeCounter >= 2) {
            rb.AddForce(Vector3.up * jumpForce);
            timeCounter = 0;
        }
    }
}
