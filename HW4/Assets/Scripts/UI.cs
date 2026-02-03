using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    private TextMeshProUGUI _score;
    private TextMeshProUGUI _endGameText;
    private int _currentScore;

    // Start is called before the first frame update
    void Start()
    {
        _currentScore = 0;
        _score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        _endGameText = GameObject.Find("Game Over").GetComponent<TextMeshProUGUI>();

        Locator.Instance.Player.EndGame += EndGameUI;
        Locator.Instance.Player.PointsChanged += UpdateScore;

        _endGameText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScore()
    {
        Debug.Log("Recieved");
        _currentScore++;
        _score.text = "Score: " + _currentScore.ToString();
        
    }

    void EndGameUI()
    {
        _endGameText.gameObject.SetActive(true);
    }
}
