using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance;
    private int currentScore = 0;

    public TMP_Text currentScoreText;

    public int coinPoints = 10;

    public void AddScore()
    {
        int points = 0;
        currentScore += points;

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (currentScoreText != null)
        {
            currentScoreText.text = "Score: " + currentScore;
        }
    }

    private void Update()
    {
        AddScore();
        UpdateUI();
    }
}
