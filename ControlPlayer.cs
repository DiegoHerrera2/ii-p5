using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation1 = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotation2 = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(-rotation1, rotation2, 0);
        
    }
}
