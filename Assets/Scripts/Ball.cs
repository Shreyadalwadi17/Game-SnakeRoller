using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 12f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = (Vector2.up * speed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obs"))
        {
            UIManager.inst.ShowNextScreen(ScreenEnum.GameOver);
            Audio.inst.SoundPlay(Audio.SoundName.GameOver);

        }
    }
}

