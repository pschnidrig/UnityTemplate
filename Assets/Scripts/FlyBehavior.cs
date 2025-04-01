using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;
    private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the bird component
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // If mouse left button is pressed, the brid should move up
        if(Mouse.current.leftButton.wasPressedThisFrame){
            _rb.linearVelocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        // Add logic to rotate the bird in the up or down position
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the bird collides with a collision object, the game ends
        GameManager.instance.GameOver();
    }
}
