using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Ball))]
[RequireComponent(typeof(Rigidbody2D))]
public class BallMover : MonoBehaviour
{
    [Header("Rotation settings")]
    [SerializeField] private GameObject _sprite;
    [SerializeField] private float _direction;
    [SerializeField] private float _speed;
    [Header("Jump settings")]
    [SerializeField] private float _height;
    [SerializeField] private float _duration;

    private Vector3 _ballGroundPosition;

    private const int CountJumps = 1;

    private void Start()
    {
        _ballGroundPosition = transform.position;
    }

    private void FixedUpdate()
    {
        Jump();
        Rotaion();
    }

    private void Rotaion()
    {
        _sprite.transform.Rotate(new Vector3(0, 0, _direction * _speed));

        if (_sprite.transform.rotation.z == -360)
            _sprite.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    private void Jump()
    {
        if((transform.position.y == _ballGroundPosition.y) && Input.GetMouseButtonDown(0))
        {
            transform.DOJump(_ballGroundPosition, _height, CountJumps, _duration, false);
        }
    }
}
