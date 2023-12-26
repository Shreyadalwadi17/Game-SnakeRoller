using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    public static ScoreManage inst;
    public Text score;
    public Text nearmiss;
    public Text level;
    public Text tryscore;
    public Text levelscore;
    void Start()
    {
        inst = this;
    }

}
