using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderB : MonoBehaviour
{
    // Start is called before the first frame update
    bool isMovingToTarget1 = true;

    public float speed;

    float timeCounter = 0;

    Vector3 point1;
    Vector3 point2;

    void Start()
    {
        point1 = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        Vector3 positionpoint1diff = point1 - transform.position;
        Vector3 positionpoint2diff = point2 - transform.position;

        moveToTarget(isMovingToTarget1 ? positionpoint1diff : positionpoint2diff);

        if (timeCounter > 2) {
            isMovingToTarget1 = !isMovingToTarget1;
            timeCounter = 0;
        }

    }

    void moveToTarget(Vector3 diff) {
        transform.Translate(diff.normalized * speed * Time.deltaTime);
    }
}
