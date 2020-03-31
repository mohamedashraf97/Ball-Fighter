using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public PlayerMovement player1;
    public Player2Movement player2;
    Text restartText;
    void Start()
    {
        restartText = GetComponent<Text>();
    }
    void Update()
    {
        if (player1.dead1 || player2.dead2)
        {
            restartText.text = "Press R to Restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);

            }
        }

    }
}
