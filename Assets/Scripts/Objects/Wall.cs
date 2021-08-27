using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Destroyer>(out Destroyer destroyer))
            gameObject.SetActive(false);

        if (collision.TryGetComponent<Ball>(out Ball ball))
        {
            ball.Die();
        }
    }
}
