using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<BallCatcher>().AddOnBallCaught(ResetTrack);
    }

    // Update is called once per frame
    void Update()
    {
        // コースの傾きを変更
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(-0.5f,0,0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0.5f, 0, 0));

        }
    }

    void ResetTrack()
    {
        transform.rotation = Quaternion.Euler(0, 0, 10);
    }
}
