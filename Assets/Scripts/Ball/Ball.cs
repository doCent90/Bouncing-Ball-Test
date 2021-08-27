using UnityEngine.Events;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject _gameOver;

    public event UnityAction Died;
    public event UnityAction Colleted;

    public void Die()
    {
        Died?.Invoke();
        _gameOver.SetActive(true);
        gameObject.SetActive(false);
    }

    public void CollectCoin()
    {
        Colleted?.Invoke();
    }
}
