using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SphereMoveScript : MonoBehaviour
{
    public float walkSpeed = 10f;
    public float runSpeed = 30f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var k = Keyboard.current;

        Vector3 dir = Vector3.zero;
        float currentSpeed = walkSpeed;
        if (k.shiftKey.isPressed) currentSpeed = runSpeed;

        if (k.wKey.isPressed) dir += Vector3.forward;
        if (k.sKey.isPressed) dir += Vector3.back;
        if (k.aKey.isPressed) dir += Vector3.left;
        if (k.dKey.isPressed) dir += Vector3.right;

        if (dir.sqrMagnitude > 1f) dir.Normalize();

        // Set velocity directly - retains vertical velocity for physics (e.g. bouncing)
        Vector3 velocity = dir * currentSpeed;
        velocity.y = rb.velocity.y; // Keep vertical component (gravity/jump/bounce)
        rb.velocity = velocity;
    }
}