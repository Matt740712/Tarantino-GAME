using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CompagnoScript : MonoBehaviour
{
    public GameObject PointC;
    public GameObject PointD;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float Speed;

 void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2); // Numero della scena desiderata
        }
}


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = PointD.transform;
    }


    

    void Update()
    {
        
        Vector2 point = new Vector2(currentPoint.position.x - transform.position.x, currentPoint.position.y - transform.position.y);

        if (currentPoint == PointD.transform)
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
        if (currentPoint == PointD.transform)
        {
            currentPoint = PointC.transform;
        }
        else
        {
            currentPoint = PointD.transform;
        }
    }
}