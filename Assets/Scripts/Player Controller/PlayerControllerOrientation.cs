using UnityEngine;

public class PlayerControllerOrientation : MonoBehaviour
{
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _direction;

    [SerializeField] private float moveSpeed = 7.0f;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");
        _verticalMovement = Input.GetAxisRaw("Vertical");

        if (_horizontalMovement != 0 || _verticalMovement != 0)
        {
            _spriteRenderer.flipX = _horizontalMovement > 0;
            _direction = new Vector3(_horizontalMovement, _verticalMovement, transform.position.z).normalized;
            transform.Translate(_direction * (moveSpeed * Time.deltaTime));
        }
    }
}
