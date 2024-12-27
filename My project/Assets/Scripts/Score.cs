using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int _score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        DrawScore();
    }

    public void AddScore(int value)
    {
        _score += value;
        DrawScore();
    }

    private void DrawScore()
    {
        scoreText.text = $"Score: {_score}";
    }
}
