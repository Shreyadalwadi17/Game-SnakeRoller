using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Lerpimg : MonoBehaviour
{
    public Image image;
    public float second = 2f;
    public float target = 0f;
    private float currentAlpha;

    private void Start()
    {
        currentAlpha = image.color.a;

    }
    private void Update()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        //start to end time of event
        float elapsedTime = Time.time;
        //Debug.Log("elapsed" + elapsedTime);
        //Debug.Log("Time" + Time.time);
        float newAlpha = Mathf.Lerp(currentAlpha, target, elapsedTime / second);

        Color newColor = image.color;
        newColor.a = newAlpha;
        image.color = newColor;
        yield return image.color;
    }

}
