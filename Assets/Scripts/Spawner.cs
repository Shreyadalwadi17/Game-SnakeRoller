using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public static Spawner inst;
    public List<Ball> balls = new List<Ball>();
    public static Action  edAction;

    public void Awake()
    {
        inst = this;
    }
    private void OnEnable()
    {
        GameStateManager.OnGameStateChanged += OnStateChanged;
    }
    private void Update()
    {
        edAction?.Invoke();
    }
    public void BallSpawn()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Ball ballobj = Instantiate(ball, transform.position, transform.rotation).GetComponent<Ball>();
            Debug.Log("ball spawn");
            Audio.inst.SoundPlay(Audio.SoundName.Shoot);
            balls.Add(ballobj);
        }
    }
    public void Ondisplayall()
    {
        for (int i = 0; i < balls.Count; i++)
        {
       
        }
    }
    public void Onreset()
    {
        for (int i = 0; i < balls.Count; i++)
        {
            Destroy(balls[i].gameObject);
        }
        balls.Clear();
    }
    public void OnStateChanged(GameState gs)
    {
        switch (gs)
        {
            case GameState.Splash:
                edAction -= BallSpawn;
                break;
            case GameState.MainMenu:
                edAction -= BallSpawn;
                break;
            case GameState.Gameplay:
                edAction += BallSpawn;
                break;
            case GameState.GameOver:
                edAction -= BallSpawn;
                break;
            case GameState.LevelComplete:
                edAction -= BallSpawn;
                break;
          
              
        }
    }
}




