using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [SerializeField]
    private Text pointsText, distanceText;
    private float reachedDistance = 0;

    private int points = 0;

    private void Start()
    {
        ItemsGenerator.Instance.Generate();
    }

    public float GetReachedDistance()
    {
        return reachedDistance;
    }

    public void SetReachedDistance(float distance)
    {
        // なんかマイナスの方に転がっていくのでdistanceが小さくなったとき更新
        if(distance < reachedDistance)
        {
            reachedDistance = distance;
            distanceText.text = "Distance: " + ((int)(-100 * reachedDistance)).ToString();
            
        }
    }

    public void AddPoints(int points)
    {
        this.points += points;
        pointsText.text = "Points: " + this.points.ToString();
    }
}
