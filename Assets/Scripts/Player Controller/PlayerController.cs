using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _direction;

    [SerializeField] private float moveSpeed = 7.0f;

    private void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");
        _verticalMovement = Input.GetAxisRaw("Vertical");

        if (_horizontalMovement != 0 || _verticalMovement != 0)
        {
            _direction = new Vector3(_horizontalMovement, _verticalMovement, transform.position.z).normalized;
            transform.Translate(_direction * (moveSpeed * Time.deltaTime));
        }
    }
}
