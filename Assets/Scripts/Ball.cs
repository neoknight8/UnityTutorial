using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<BallCatcher>().AddOnBallCaught(ResetBall);
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.SetReachedDistance(transform.position.x);
    }

    public void ResetBall()
    {
        gameObject.transform.position = new Vector3(GameManager.Instance.GetReachedDistance(), 9, 0);
    }
}
