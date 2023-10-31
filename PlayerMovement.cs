using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public delegate void notification();

    public event notification OnTouchBedWithPerson;
    public float movementSpeed;
    public float jumpForce;

    private int points;

    private Rigidbody rb;
    public KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SpiderEvents.OnPlayerStomp += OnPlayerStomp;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        rb.AddForce(playerInput * movementSpeed);

        if (Input.GetKeyDown(key)) {
            rb.AddForce(Vector3.up * jumpForce);
            Debug.Log("Jump");
        }
    }

    void OnPlayerStomp(int points) {
        this.points += points;
        Debug.Log("Points: " + this.points);
    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "bed with person with blood")
        {
            Debug.Log("Touching bed with person");
            OnTouchBedWithPerson?.Invoke();
        }
    }
}