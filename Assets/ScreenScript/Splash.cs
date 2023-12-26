using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Splash : screen
{
    public Image image;
    public static Splash inst;

    private void Start()
    {
        inst = this;
        image = GetComponent<Image>();

        UIManager.inst.ShowNextScreen(ScreenEnum.Splash);
        StartCoroutine(EnableMainMenu());

    }
    IEnumerator EnableMainMenu()
    {
        yield return new WaitForSeconds(2);
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
    }

}
