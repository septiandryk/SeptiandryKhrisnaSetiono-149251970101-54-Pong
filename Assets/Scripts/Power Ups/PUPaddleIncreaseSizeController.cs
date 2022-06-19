using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleIncreaseSizeController : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public BallController ballcontroller;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (ballcontroller.isRight == true)
            {
                manager.paddleKananExpand = true;
                manager.paddleKanan.GetComponent<PaddleController>().ActivatePUIncreasePaddleSize();
                manager.RemovePowerUp(gameObject);
            }


            else
            {
                manager.paddleKananExpand = false;
                manager.paddleKiri.GetComponent<PaddleController>().ActivatePUIncreasePaddleSize();
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
