using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private Animator _animator;
    private int _isRunning;
    private int _isJumping;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _isRunning = Animator.StringToHash("IsRunning");
        _isJumping = Animator.StringToHash("IsJumping");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool(_isRunning, true);
            _playerMovement.GoByKeyD();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool(_isRunning, true);
            _playerMovement.GoByKeyA();
        }

        if(!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            _animator.SetBool(_isRunning, false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool(_isJumping, true);
            _playerMovement.Jump();
        }

        if (!Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool(_isJumping, false);
        }
    }
}