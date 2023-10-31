using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairListener : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement OnPlayerTouchBedWithPerson;

    Rigidbody rb;
    bool alreadyPlayed = false;

    private float timeCounter = 0;
    void Start()
    {
        OnPlayerTouchBedWithPerson.OnTouchBedWithPerson += jump;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!alreadyPlayed) {
            return;
        }
        timeCounter -= Time.deltaTime;
        
        if (timeCounter <= 0) {
            rb.AddForce(Vector3.up * 100f);
            timeCounter = 2;
        }

    }

    void jump() {
        alreadyPlayed = true;
    }
}
