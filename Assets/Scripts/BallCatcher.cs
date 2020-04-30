using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void BallCatchHandler();
public class BallCatcher : MonoBehaviour
{
    public BallCatchHandler OnBallCaught;

    public void AddOnBallCaught(BallCatchHandler handler)
    {
        OnBallCaught += handler;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            OnBallCaught();
        }
    }
}
