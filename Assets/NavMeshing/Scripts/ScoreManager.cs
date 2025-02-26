using TMPro; // Text Mesh Pro
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreManager : MonoBehaviour
{
    public Text label;
    private int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        label = GetComponent<Text>();
        ResetScore();
    }

    public void ResetScore()
    {
        score = 0;
        label.text = score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
        label.text = score.ToString();
    }
}
