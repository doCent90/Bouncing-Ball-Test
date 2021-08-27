using UnityEngine;

public class Spawn : PoolObjects
{
    [SerializeField] private float _delayMin;
    [SerializeField] private float _delayMax;

    [SerializeField] private Ball _ball;

    private float _elapsedTime;
    private bool _isGameOver;

    private void OnEnable()
    {
        _ball.Died += OnDied;
    }

    private void OnDisable()
    {
        _ball.Died -= OnDied;
    }

    private void Start()
    {
        _isGameOver = false;
        Initialize();
    }

    private void Update()
    {
        if (!_isGameOver)
        {
            _elapsedTime += Time.deltaTime;

            if (_elapsedTime >= Random.Range(_delayMin, _delayMax))
            {
                if (TryGetObject(out GameObject gameObject))
                {
                    _elapsedTime = 0;
                    SetObject(gameObject);
                }
            }
        }        
    }

    private void SetObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = transform.position;
    }

    private void OnDied()
    {
        _isGameOver = true;
        this.enabled = false;
    }
}
