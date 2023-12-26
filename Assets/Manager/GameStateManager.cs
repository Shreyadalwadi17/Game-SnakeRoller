using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum GameState
{
    Splash,
    MainMenu,
    Gameplay,
    GameOver,
    LevelComplete
}
public class GameStateManager : MonoBehaviour
{
    public static GameStateManager inst;
    public static event Action<GameState> OnGameStateChanged;//EventAction
    public GameState curruntstate;

    void Awake()
    {
        inst = this;
    }
  
 
    public void UpdateGameState(GameState gs)
    {
        curruntstate = gs;
        OnGameStateChanged?.Invoke(gs);
    }

}






