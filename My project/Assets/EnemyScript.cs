using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float Speed;


    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Destroy(gameObject);
    }
}

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = PointB.transform;
    }

    void Update()
    {
        Vector2 point = new Vector2(currentPoint.position.x - transform.position.x, currentPoint.position.y - transform.position.y);

        if (currentPoint == PointB.transform)
        {
            rb.velocity = new Vector2(Speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-Speed, 0);
        }

        if (Mathf.Abs(point.x) < 0.1f)
        {
            Flip();
        }
    }

    void Flip()
    {
        if (currentPoint == PointB.transform)
        {
            currentPoint = PointA.transform;
        }
        else
        {
            currentPoint = PointB.transform;
        }
    }
}