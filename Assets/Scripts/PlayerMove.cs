﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController playerController;
    public Transform groundCheck;
    public LayerMask groundMask;

    [Header("Pelaajan parametrit")]
    public float moveSpeed = 8f;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;

    private Vector3 velocity;
    private bool isOnGround;

    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        move = transform.right * horizontal + transform.forward * vertical;
        playerController.Move(move * moveSpeed * Time.deltaTime);
    }
}