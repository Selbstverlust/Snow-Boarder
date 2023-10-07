using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    private float baseSpeed;
    bool canMove = true;
    [SerializeField] private float accelerateSpeed;
    [SerializeField] private float torqueAmount = 800f;
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        baseSpeed = surfaceEffector2D.speed;
    }
    void Update()
    {
        if (canMove) {
        AcceleratePlayer();
        RotatePlayer();
        }
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }
    public void DisableControls() {
        canMove = false;
    }
    private void AcceleratePlayer()
    {
        if (Input.GetKey(KeyCode.W)) {
            surfaceEffector2D.speed = baseSpeed + accelerateSpeed;
        }
        else if (Input.GetKey(KeyCode.S)) {
            surfaceEffector2D.speed = baseSpeed - accelerateSpeed;
        }
        else {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A)) {
            rb2d.AddTorque(torqueAmount * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D)) {
            rb2d.AddTorque(-torqueAmount * Time.deltaTime);
        }
    }
}
