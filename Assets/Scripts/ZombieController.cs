using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;

    private Rigidbody2D rigidBody;
    private PlayerDetector playerDetector;
    private Vector2 targetDirection;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerDetector = GetComponent<PlayerDetector>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }
    private void UpdateTargetDirection()
    {
        if (playerDetector.AwareOfPlayer) {
            targetDirection = playerDetector.DirectionToPlayer;
        } else {
            targetDirection = Vector2.zero;
        }
    }

    private void RotateTowardsTarget()
    {
        if (targetDirection == Vector2.zero) {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        rigidBody.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        if (targetDirection == Vector2.zero) {
            rigidBody.velocity = Vector2.zero;
            return;
        } else {
            rigidBody.velocity = transform.up * speed;
        }
    }
}
