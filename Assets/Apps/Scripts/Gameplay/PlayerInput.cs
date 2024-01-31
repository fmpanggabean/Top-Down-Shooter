using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private IMovement movement;

    private void Awake()
    {
        movement = GetComponent<IMovement>();
    }

    private void Update()
    {
        movement.SetDirection(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}
