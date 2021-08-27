using UnityEngine.Events;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public event UnityAction Died;
    public event UnityAction Colleted;

    public void Die()
    {
        Died?.Invoke();
        gameObject.SetActive(false);
    }

    public void CollectCoin()
    {
        Colleted?.Invoke();
    }
}
