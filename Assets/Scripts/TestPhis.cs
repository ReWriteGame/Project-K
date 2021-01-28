using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhis : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    float moveX;
    float moveZ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()// обнавляеться все зависимости от частоты кадров в отличии от Update
    {
        moveX = Input.GetAxis("Horizontal") * speed;// right left
        moveZ = Input.GetAxis("Vertical") * speed;// top bottom

        transform.Translate(moveX, moveZ, 0);// x y z

     
       

    }
}


