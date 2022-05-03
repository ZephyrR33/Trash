using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }
    public int _score;
    [SerializeField] private TextMeshProUGUI scoreText;
    public void Start()
    {
        _score = PlayerPrefs.GetInt("Score", _score);
    }
    private void Update()
    {
        PlayerPrefs.SetInt("Score", _score);
        scoreText.SetText(sourceText: $"Score = {_score}");

    }

    private void Awake() => Instance = this;
}
