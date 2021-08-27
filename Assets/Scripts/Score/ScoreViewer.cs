using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Ball _ball;

    private Coin _coin;
    private int _score = 0;

    private void OnEnable()
    {
        _ball.Colleted += Increase;
        _scoreText.text = "Coins - 0";
    }

    private void OnDisable()
    {
        _ball.Colleted += Increase;
    }

    private void ShowPoints()
    {
        _scoreText.text = $"Coins - {_score.ToString()}";
    }

    private void Increase()
    {
        _score++;
        ShowPoints();
    }
}
