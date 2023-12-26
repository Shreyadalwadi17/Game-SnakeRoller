using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField]public float speed;
    public List<GameObject> rings;
    public static Circle inst;
    public int counterlevel = 0;

  
    private void Awake()
    {
        inst = this;
    }
    private void Start()
    {
        counterlevel = LevelManager.inst.levelno;
        Timer();
      
        if(counterlevel==1)
        {
            speed = Random.Range(-50, 100);

            BallScore.inst.ballscore=10;
            BallScore.inst.ballscoretxt.text = BallScore.inst.ballscore.ToString();
            Debug.Log("speed100");
          
        }
        if (counterlevel == 2)
        {
            speed = Random.Range(-100, 200);
            BallScore.inst.ballscore = 20;
            BallScore.inst.ballscoretxt.text = BallScore.inst.ballscore.ToString();
            Debug.Log("speed200");
        }
        if (counterlevel == 3)
        {
            speed = Random.Range(-150, 300);
            BallScore.inst.ballscoretxt.text = BallScore.inst.ballscore.ToString();
            BallScore.inst.ballscore = 30;
            Debug.Log("speed300");
        }

    }
    void Update()
    {
        for (int i = 0; i < rings.Count; i++)
        {
            if (i % 2 == 0)
            {
                rings[i].transform.Rotate(0f, 0f, speed * Time.deltaTime);
            }
            else
            {
                rings[i].transform.Rotate(0f, 0f, -speed * Time.deltaTime);
            }
        }
    }
 
    public void Timer()
    {
        Invoke("Timer", 5);
        
        
    }
    

}
