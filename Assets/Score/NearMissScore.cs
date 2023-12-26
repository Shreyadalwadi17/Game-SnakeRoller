using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NearMissScore : MonoBehaviour
{
    public int point = 0;

    private void Awake()
    {
        ScoreManage.inst.nearmiss.text = PlayerPrefs.GetInt("point", 0).ToString();
    }
    private void Update()
    {
        PlayerPrefs.SetInt("point", point);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        point = point + 20;
        ScoreManage.inst.nearmiss.text = point.ToString();
    }

}
