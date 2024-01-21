using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemyMovement : MonoBehaviour
{
    public GameObject pointA;//oddanie obiektu granicy punktu a
    public GameObject pointB;//oddanie obiektu granicy punktu b
    private Rigidbody2D rb;//fizyka przeciwnika
    private Transform currentPoint;//punkt aktualny
    public float speed;//prekosc ruchu przeciwnika
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }
    // Update is called once per frame
    void Update()
    {
        //ustalanie odleglosci od aktulanego jednego naszego punktu
        Vector2 point = currentPoint.position - transform.position;
        //if do ustalania kierunku poruszania siê przeciwnika
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        //if do mierzenia dystansu od naszego punktu i potem ustalanie nowego celu dla przeciwnika
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint
== pointB.transform)
        {
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f &&
currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }
}