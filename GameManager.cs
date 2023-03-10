using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;
    
    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int player1Score;
    private int player2Score;


    public void Player1Scored()
    {
        player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPositions();
    }
   
    public void Player2Scored()
    {
        player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPositions();
    }

    private void ResetPositions()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
