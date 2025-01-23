using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int Score;
    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + Score;
    }
}
