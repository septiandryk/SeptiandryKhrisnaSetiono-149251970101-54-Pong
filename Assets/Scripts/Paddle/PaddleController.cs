using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

    public void ActivatePUSpeedUpPaddle()
    {
        speed *= 2;
        StartCoroutine(waitTimeSpeed());
    }

    IEnumerator waitTimeSpeed()
    {
        yield return new WaitForSeconds(5);
        speed /= 2;
    }


    public void ActivatePUIncreasePaddleSize()
    {
        gameObject.transform.localScale *= 2;
        StartCoroutine(waitTimeSize());
    }

    IEnumerator waitTimeSize()
    {
        yield return new WaitForSeconds(5);
        gameObject.transform.localScale = new Vector3(0.31f, 1.7f, 1f);
    }



}