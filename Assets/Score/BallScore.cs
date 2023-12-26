using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{

    public static BallScore inst;
    public int ballscore;
    public Text ballscoretxt;

    private void Awake()
    {
        inst = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("scoreobs"))
        {
            ballscore = ballscore - 1;
            ballscoretxt.text = ballscore.ToString();

            if (ballscore <= 0)
            {
                UIManager.inst.ShowNextScreen(ScreenEnum.LevelComplete);

            }
            else
            {
                ballscoretxt.text = ballscore.ToString();
            }

        }

    }
 
}
