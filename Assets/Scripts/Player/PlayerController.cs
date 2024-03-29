using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementX;
    private float movementY;

    public float speed;
    public float speedRot = 5f;
    public float speedMax = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnFire()
    {
        SoundManager.Instance.PlayShoot();
    }


    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(movementX, movementY) * speed;
        rb.rotation -= movementX * speedRot;
        speed = Mathf.Clamp(speed+movementY, 1.5f, 5);
        rb.velocity = transform.up * speed;
    }
}
