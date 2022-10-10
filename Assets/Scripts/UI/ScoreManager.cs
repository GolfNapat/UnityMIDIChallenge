using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    PlayerManager playerManager;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int scoreCount;

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    public void Start()
    {
        scoreCount = 0;
        scoreText.text = scoreCount.ToString();
    }

    public void ScoreHandler()
    {
        scoreCount = playerManager.score;
        scoreText.text = scoreCount.ToString();
    }
}
