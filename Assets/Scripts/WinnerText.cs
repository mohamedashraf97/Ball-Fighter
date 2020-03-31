using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinnerText : MonoBehaviour
{
    public PlayerMovement player1;
    public Player2Movement player2;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    void Update()
    {
        if (player1.dead1)
        {

            scoreText.text = "Ouch Player 2 Win";
        }
        else if (player2.dead2)
        {
            scoreText.text = "Ouch Player 1 Win";

        }
    }
}
