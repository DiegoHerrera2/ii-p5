using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void notification(int points);
    public static event notification OnPlayerStomp;

    private float deathByPointingTimer = 1;

    bool pointing = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pointing) deathByPointingTimer -= Time.deltaTime;
        if (deathByPointingTimer <= 0) {
            gameObject.SetActive(false);
        }
    }

        void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Player" && collision.gameObject.transform.position.y > transform.position.y)
        {
            OnPlayerStomp?.Invoke(10);
            gameObject.SetActive(false);
        }
    }

    void OnPointerEnter() {
        pointing = true;
    }

    void OnPointerExit() {
        pointing = false;
        deathByPointingTimer = 1;
    }
}
