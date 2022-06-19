using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    public GameObject ball;
    public bool isRight;

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
        StartCoroutine(waitTimeSpeedUp());
    }

    IEnumerator waitTimeSpeedUp()
    {
        yield return new WaitForSeconds(5);
        rig.velocity /= 2f;
    }

    public void ActivatePUSpeedDown(float magnitude)
    {
        rig.velocity /= magnitude;
        StartCoroutine(waitTimeSpeedDown());
    }

    IEnumerator waitTimeSpeedDown()
    {
        yield return new WaitForSeconds(5);
        rig.velocity *= 1.2f;
    }

    public void ActivatePUInstantiateNewBall()
    {
        Instantiate(ball);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Paddle Kanan")
        {
            isRight = true;
        }

        if (collision.gameObject.name == "Paddle Kiri")
        {
            isRight = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
