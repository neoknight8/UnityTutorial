using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsGenerator : SingletonMonoBehaviour<ItemsGenerator>
{
    [SerializeField]
    private GameObject[] prehabs;
    [SerializeField]
    private int itemCount;
    private const int MIN_X = 6, MAX_X = 60;
    private const float MIN_Z = -3, MAX_Z = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Generate()
    {
        for (int i = 0; i < itemCount; i++)
        {
            int type = Random.Range(0, 4);
            int x = -1 * Random.Range(MIN_X, MAX_X);
            float z = Random.Range(MIN_Z, MAX_Z);

            Instantiate(prehabs[type], new Vector3(x, 10, z), Quaternion.Euler(0, 0, 0));
        }

    }
}
