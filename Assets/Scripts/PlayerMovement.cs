using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidBody2D;
    [SerializeField] private float _jumpForce;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void GoByKeyD()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }

    public void GoByKeyA()
    {
        transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
    }

    public void Jump()
    {
        _rigidBody2D.AddForce(new Vector2(0, _jumpForce));
    }



}
