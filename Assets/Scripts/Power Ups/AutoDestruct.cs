using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruct : MonoBehaviour
{

    public float PULifeTime;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(this.gameObject, PULifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
