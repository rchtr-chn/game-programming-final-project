using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Movement(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }

    public void SetDirection(CallbackContext receiver)
    {
        if(receiver.phase == UnityEngine.InputSystem.InputActionPhase.Performed
            || receiver.phase == UnityEngine.InputSystem.InputActionPhase.Canceled)
        {
            Vector2 dir = receiver.ReadValue<Vector2>();
            Movement(dir);
        }
    }
}
