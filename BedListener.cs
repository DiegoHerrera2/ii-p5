using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedListener : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement OnPlayerTouchBedWithPerson;
    bool alreadyPlayed = false;

    private float timeCounter = 0;
    void Start()
    {
        OnPlayerTouchBedWithPerson.OnTouchBedWithPerson += moveSideToSide;
    }

    // Update is called once per frame
    void Update()
    {
        if (!alreadyPlayed) {
            return;
        }
        timeCounter += Time.deltaTime;

        if (timeCounter <= 2) {
            transform.Translate(Vector3.left * 1f * Time.deltaTime);
        }
        else if (timeCounter <= 4) {
            transform.Translate(Vector3.right * 1f * Time.deltaTime);
        }
        else {
            timeCounter = 0;
        }


    }

    void moveSideToSide() {
        alreadyPlayed = true;
    }
}
