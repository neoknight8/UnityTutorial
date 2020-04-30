using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private Type itemType;

    enum Type
    {
        PointsS = 0,
        PointsM = 1,
        PointsL = 2,
        Trap = 3
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Track")
        {
            SetCollider(collision.collider.transform);
        }

        // トラップにぶつかったとき
        if(collision.collider.tag == "Ball" && itemType == Type.Trap)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball" && (itemType == Type.PointsS || itemType == Type.PointsM || itemType == Type.PointsL))
        {
            switch (itemType)
            {
                case Type.PointsS:
                    GameManager.Instance.AddPoints(10);
                    Destroy(gameObject);
                    break;
                case Type.PointsM:
                    GameManager.Instance.AddPoints(50);
                    Destroy(gameObject);
                    break;
                case Type.PointsL:
                    GameManager.Instance.AddPoints(100);
                    Destroy(gameObject);
                    break;
            }
        }
    }

    public void SetCollider(Transform parentTransform)
    {
        switch(itemType)
        {
            case Type.PointsS:
            case Type.PointsM:
            case Type.PointsL:
                transform.parent = parentTransform;
                Destroy(GetComponent<Rigidbody>());
                GetComponent<SphereCollider>().isTrigger = true;
                break;
            case Type.Trap:
                transform.parent = parentTransform;
                Destroy(GetComponent<Rigidbody>());
                break;
        }
    }
}
