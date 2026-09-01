using UnityEngine;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    public int Score;
    public int TradeScore;

    public TMP_Text scoreText;
    public TMP_Text tradeScoreText;

    void Start()
    {
        Score = 0;
        TradeScore = 0;

        UpdateText();
    }

    public void AddScore()
    {
        Score++;

        UpdateText();
    }

    public void Trade()
    {
        if (Score >= 10)
        {
            Score -= 10;
            TradeScore++;

            UpdateText();
        }
    }

    void UpdateText()
    {
        scoreText.text = "Score: " + Score;
        tradeScoreText.text = "Trade Score: " + TradeScore;
    }
}