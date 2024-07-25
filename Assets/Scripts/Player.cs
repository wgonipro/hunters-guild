using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDist = 0.5f;
    Rigidbody2D rb;
    bool firstTime = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            float x = transform.position.x;
            x -= moveDist;
            newPos = new Vector2(x, transform.position.y);
        } 
        else if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            float x = transform.position.x;
            x += moveDist;
            newPos = new Vector2(x, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float y = transform.position.y;
            y += moveDist;
            newPos = new Vector2(newPos.x, y);
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            float y = transform.position.y;
            y -= moveDist;
            newPos = new Vector2(newPos.x, y);
        }

        this.transform.position = newPos;

    }
}
