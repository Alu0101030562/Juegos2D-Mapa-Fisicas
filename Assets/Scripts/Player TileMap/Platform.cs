using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float leftLimit;
    [SerializeField] private float rightLimit;
    
    [SerializeField] private float moveSpeed = 1.0f;
    
    private Rigidbody2D _rigidbody2D;
    private bool _isHeadingRight;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (transform.position.x < leftLimit)
        {
            _rigidbody2D.MovePosition(transform.position + Vector3.right * (moveSpeed * Time.fixedDeltaTime));
            _isHeadingRight = true;
        } else if (transform.position.x > rightLimit)
        {
            _rigidbody2D.MovePosition(transform.position + Vector3.left * (moveSpeed * Time.fixedDeltaTime));
            _isHeadingRight = false;
        } else if (transform.position.x > leftLimit && transform.position.x < rightLimit)
        {
            if (_isHeadingRight)
                _rigidbody2D.MovePosition(transform.position + Vector3.right * (moveSpeed * Time.fixedDeltaTime));
            else
                _rigidbody2D.MovePosition(transform.position + Vector3.left * (moveSpeed * Time.fixedDeltaTime));
        }
    }
}
