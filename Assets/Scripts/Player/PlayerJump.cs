using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _forceJump;
    [SerializeField] private Transform _feetPosition;
    [SerializeField] private LayerMask _whatIsGround;
    [SerializeField] private Vector3 _boxController;
    [SerializeField] private bool _isGrounded;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioClip _jumpClip;
    private Rigidbody2D _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        _isGrounded = Physics2D.OverlapBox(_feetPosition.position, _boxController, 0f, _whatIsGround);


        if (Input.GetButtonDown("Jump"))
        {
            if (_isGrounded)
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 0f); 
                _rigidbody.AddForce(Vector2.up * _forceJump, ForceMode2D.Impulse);
                SoundController.Instance.PlaySound(_jumpClip);
            }
        }
        _animator.SetFloat("Vertical", _rigidbody.velocity.y);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(_feetPosition.position, _boxController);
    }
}
