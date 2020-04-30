using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(target.transform.position.x + 3, target.transform.position.y + 0.8f, gameObject.transform.position.z);
        gameObject.transform.rotation.SetLookRotation(target.transform.position);
    }
}
