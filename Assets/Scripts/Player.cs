using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb;

    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }

    private void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.AddTorque(torqueAmount);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {

            rb.AddTorque(-torqueAmount);

        }
    }
}
