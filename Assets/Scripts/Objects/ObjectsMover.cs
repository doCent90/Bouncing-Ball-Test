using UnityEngine;

public class ObjectsMover : MonoBehaviour
{
    [SerializeField] private float _direction;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(new Vector3(_direction, 0, 0) * _speed * Time.deltaTime);
    }
}
