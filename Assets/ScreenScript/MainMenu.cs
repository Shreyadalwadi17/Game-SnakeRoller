using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : screen
{
    public GameObject SettingPanel;
    public ParticleSystem partical;

    public void Start()
    {
        SettingPanel.SetActive(false);
        partical.Play();
        
    }

    public void OnPlayButton()
    {
        partical.Stop();
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.BackgroundMusic(Audio.SoundName.Background);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        //GameStateManager.inst.UpdateGameState(GameState.Gameplay);

    }

    public void OnSettingButton()
    {
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(true);
    }

    public void OnBackButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(false);
    }

    public void OnSaveButton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(false);

       
    
    }

    public void OnDefaultButtton()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        SettingPanel.SetActive(false);

        Seting.inst.soundslider.value = 1;
        Seting.inst.bgsoundslider.value = 1;
        Debug.Log("sound");

    }


}
