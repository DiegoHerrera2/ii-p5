using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderA : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject chair;

    public float speed;
    public GameObject table;


    bool isMovingToTable = true;

    float timeCounter = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        Vector3 positiontablediff = table.transform.position - transform.position;
        Vector3 positionchairdiff = chair.transform.position - transform.position;

        moveToTarget(isMovingToTable ? positiontablediff : positionchairdiff);

        if (timeCounter > 2) {
            isMovingToTable = !isMovingToTable;
            timeCounter = 0;
        }

    }

    void moveToTarget(Vector3 diff) {
        transform.Translate(diff.normalized * speed * Time.deltaTime);
    }


}
