using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour { 
    private Rigidbody2D rb2D;
    public bool TimedOut = false;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (TimedOut == false) { Debug.Log(TimedOut); }
        if ((Time.fixedTime + 1) % 5 == 0)
        {
            TimedOut = false;
            Debug.Log(TimedOut);
        }
        if (Time.fixedTime % 10 == 0 && !TimedOut)
        {
            rb2D.AddForce(new Vector2(0f, -15), ForceMode2D.Impulse);
            TimedOut = true;
            Debug.Log(TimedOut);
        }
        else if (Time.fixedTime % 5 == 0 && !TimedOut)
        {
            rb2D.AddForce(new Vector2(0f, 15), ForceMode2D.Impulse);
            TimedOut = true;
            Debug.Log(TimedOut);
        }
    }
}
