using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : screen
{


    private void Update()
    {
        Ondisplay();
    }

    public void OnHomeButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        LevelManager.inst.OnLoadLvel();
        Score.inst.Reset();
        Spawner.inst.Onreset();
    }
    public void NextBtn()
    {
        LevelManager.inst.OnLoadLvel();
        LevelManager.inst.NextButton();
        Spawner.inst.Onreset();
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.GameComplete);
        Score.inst.Reset();



    }
    void Ondisplay()
    {
        ScoreManage.inst.levelscore.text = Score.inst.score.ToString();
    }

}
