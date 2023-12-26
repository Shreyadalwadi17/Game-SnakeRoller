using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Seting : MonoBehaviour
{
    public Slider soundslider;
    public Slider bgsoundslider;
    public AudioSource audiosource;
    public AudioSource bgaudiosource;
    public float soundslidervalue;
    public float bgsoundslidervalue;
    public Button savebtn;
    public Button defaultbtn;
    public static Seting inst;


    private void Awake()
    {
        inst = this;
    }
    public void Start()
    {
        soundslider.value = 1;
        bgsoundslider.value = 1;
        soundslider.value = PlayerPrefs.GetFloat("save", soundslidervalue);
        bgsoundslider.value = PlayerPrefs.GetFloat("save", bgsoundslidervalue);

    }
    public void Update()
    {
        audiosource.volume = soundslider.value;
        bgaudiosource.volume = bgsoundslider.value;
        PlayerPrefs.SetFloat("save", soundslidervalue);
        PlayerPrefs.SetFloat("save", soundslidervalue);
    }
    public void Onpluse()
    {
        audiosource.volume = soundslider.value += 0.1f;
        bgaudiosource.volume = bgsoundslider.value += 0.1f;
    }
    public void Onminus()
    {
        audiosource.volume = soundslider.value -= 0.1f;
        bgaudiosource.volume = bgsoundslider.value -= 0.1f;
    }

}
