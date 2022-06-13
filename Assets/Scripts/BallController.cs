using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    public GameObject ball;

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void ActivatePUSpeedDown(float magnitude)
    {
        rig.velocity /= magnitude;
    }

    public void ActivatePUInstantiateNewBall()
    {
        Instantiate(ball);
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
