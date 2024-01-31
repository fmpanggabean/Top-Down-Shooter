using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Ship : MonoBehaviour, IMovement
{
    private Rigidbody2D rb2d;

    [SerializeField] private float speed;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(float x, float y)
    {
        rb2d.velocity.Set(x * speed, y * speed);
    }
}
