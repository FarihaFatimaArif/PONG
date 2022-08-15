using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int playerScore;
    int aiScore;
    bool check;
    Touch touch;
    [SerializeField] BallMovement Ball;
    [SerializeField] Text PlayerScoreText;
    [SerializeField] Text AIScoreText;
    [SerializeField] GameObject StartText;
    [SerializeField] Paddle PlayerPaddle;
    [SerializeField] Paddle AIPaddle;
    // Start is called before the first frame update
    void Start()
    {
        check = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!check && Input.touchCount > 0)
        { 
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                check = true;
                Ball.ResetBall();
                Ball.MoveBall();
                StartText.SetActive(false);
            }
        }
    }
    public void PlayerScore()
    {
        playerScore++;
        PlayerScoreText.text = playerScore.ToString();
        ResetRound();
    }
    public void AiScore()
    {
        aiScore++;
        AIScoreText.text = aiScore.ToString();
        ResetRound();
    }
    void ResetRound()
    {
        PlayerPaddle.ResetPaddle();
        AIPaddle.ResetPaddle();
        Ball.ResetBall();
        Ball.MoveBall();
    }
}
