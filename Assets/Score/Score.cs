using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score inst;
    public int score = 0;

    private void Awake()
    {
        inst = this;
        ScoreManage.inst.score.text = PlayerPrefs.GetInt("Score", 0).ToString();

    }
    private void Update()
    {
        PlayerPrefs.SetInt("Score", score);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        score = score + 10;
        Debug.Log("scoree"+score);
        ScoreManage.inst.score.text=score.ToString();
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        ScoreManage.inst.score.text = "0";
        ScoreManage.inst.nearmiss.text = "0";

    }
}
