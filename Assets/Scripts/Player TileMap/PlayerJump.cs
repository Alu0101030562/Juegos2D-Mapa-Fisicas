using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private float jumpForce = 7.5f;
    
    private float _horizontalMovement;
    private Vector3 _direction;
    
    private bool _isJumping;
    private bool _isGrounded;
    
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    
    private static readonly int IsWalking = Animator.StringToHash("isWalking");
    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");

        if (_horizontalMovement != 0 & !_isJumping)
        {
            _animator.SetBool(IsWalking, true);
            _spriteRenderer.flipX = _horizontalMovement > 0;
            
            _direction = new Vector3(_horizontalMovement, 0, 0).normalized;
        }
        else
            _animator.SetBool(IsWalking, false);
        
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
            _isJumping = true;
    }
    
    private void FixedUpdate()
    {
        if (_horizontalMovement != 0 && _isGrounded)
            _rigidbody2D.MovePosition(transform.position + _direction * (moveSpeed * Time.fixedDeltaTime));

        if (_isJumping && _isGrounded)
        {
            _isGrounded = false;
            _rigidbody2D.AddForce(new Vector2(_horizontalMovement / 2, 1) * jumpForce, ForceMode2D.Impulse);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log($"<{gameObject.name}> has collided with <{other.gameObject.name}>");

        if (other.gameObject.layer == LayerMask.NameToLayer("Ground") || other.gameObject.layer == LayerMask.NameToLayer("Invisible"))
        {
            _isJumping = false;
            _isGrounded = true;
            _rigidbody2D.velocity = Vector2.zero; // Cancel any remaining speed
            transform.SetParent(other.gameObject.transform);
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Invisible"))
        {
            other.gameObject.GetComponent<TilemapRenderer>().enabled = true;
            _rigidbody2D.AddForce(Vector3.up * 15, ForceMode2D.Impulse);
        }
    }
    
    private void OnCollisionExit2D(Collision2D _)
    {
        transform.SetParent(null);
    }
}
