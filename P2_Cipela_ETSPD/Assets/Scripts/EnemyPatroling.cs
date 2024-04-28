using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatroling : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    public Rigidbody2D rb;
    public Transform CurrectPos;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        CurrectPos = PointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = CurrectPos.position - transform.position;
        if (CurrectPos == PointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, CurrectPos.position) < 0.5f && CurrectPos == PointB.transform)
        {
            CurrectPos = PointA.transform;
        }
        if (Vector2.Distance(transform.position, CurrectPos.position) < 0.5f && CurrectPos == PointA.transform)
        {
            CurrectPos = PointB.transform;
        }
    }
}