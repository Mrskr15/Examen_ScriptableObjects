using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rBody.velocity.y);
    }
}