using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddleController : MonoBehaviour
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
                manager.paddleKanan.GetComponent<PaddleController>().ActivatePUSpeedUpPaddle();
                manager.RemovePowerUp(gameObject);
            }


            else
            {
                manager.paddleKiri.GetComponent<PaddleController>().ActivatePUSpeedUpPaddle();
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
