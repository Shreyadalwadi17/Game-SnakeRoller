using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager inst;
    public List<screen> screenList;
    public screen currentScreen;

    private void Awake()
    {
        inst = this;
        //currentScreen = screenList[0];
    }
    private void Start()
    {
       // currentScreen.enabled = true;
        GameStateManager.inst.curruntstate = GameState.Splash;
    }

    public void ShowNextScreen(ScreenEnum ScreenType)
    {
        if (currentScreen != null)
            currentScreen.HideScreen();
        screenList[(int)ScreenType].ShowScreen();
        currentScreen = screenList[(int)ScreenType];

        //currentScreen.enabled = false;

        //foreach (screen screens in screenList)
        //{
        //    if (screens.ScreenType == ScreenType)
        //    {
        //        screens.enabled = true;
        //        currentScreen = screens;
        //        break;
        //    }

        //}
        switch (ScreenType)
        {
            case ScreenEnum.Splash:
                GameStateManager.inst.UpdateGameState(GameState.Splash);
                break;
            case ScreenEnum.MainMenu:
                GameStateManager.inst.UpdateGameState(GameState.MainMenu);
                break;
            case ScreenEnum.GamePlay:
                GameStateManager.inst.UpdateGameState(GameState.Gameplay);
                break;
            case ScreenEnum.GameOver:
                GameStateManager.inst.UpdateGameState(GameState.GameOver);
                break;
            case ScreenEnum.LevelComplete:
                GameStateManager.inst.UpdateGameState(GameState.LevelComplete);
                break;
        }
    }
}



