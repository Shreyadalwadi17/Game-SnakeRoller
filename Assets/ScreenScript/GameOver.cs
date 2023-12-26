using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : screen
{


    private void Update()
    {
        display();
    }
    public void Try()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Try);
    }
    public void OnHomeButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        LevelManager.inst.OnLoadLvel();
        Score.inst.Reset();
        Spawner.inst.Onreset();
        
    }
    void display()
    {
        ScoreManage.inst.tryscore.text = Score.inst.score.ToString();
    }
}
