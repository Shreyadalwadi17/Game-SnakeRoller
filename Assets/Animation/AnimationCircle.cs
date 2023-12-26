using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCircle : MonoBehaviour
{
    private float speed = 200;
    public GameObject snake;

    void FixedUpdate()
    {
        snake.transform.Rotate(0f, 0f, speed * Time.deltaTime);
        Debug.Log("h");
    }

}
