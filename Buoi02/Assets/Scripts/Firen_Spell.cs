using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firen_Spell : MonoBehaviour
{
    Rigidbody2D rgdBody2D;

    void Start()
    {

        rgdBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        rgdBody2D.AddForce(new Vector2(2, 0));
    }
}
