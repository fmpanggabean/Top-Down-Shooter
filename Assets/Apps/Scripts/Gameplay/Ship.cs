using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Ship : MonoBehaviour, IMovement, IShoot
{
    private Rigidbody2D rb2d;
    private Weapon weapon;

    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        weapon = GetComponentInChildren<Weapon>();
    }

    public void SetDirection(float x, float y)
    {
        direction.x = x;
        direction.y = y;
        rb2d.velocity = direction * speed;
    }

    public void Shoot()
    {
        weapon.Shoot();
    }
}
