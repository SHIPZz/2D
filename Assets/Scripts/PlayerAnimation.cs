using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private PlayerMovement _playerMovement;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("IsRunning", true);
            _playerMovement.GoByKeyD();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("IsRunning", true);
            _playerMovement.GoByKeyA();
        }

        if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("IsJumping", true);
            _playerMovement.Jump();
        }

        if (!Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("IsJumping", false);
        }
    }
}