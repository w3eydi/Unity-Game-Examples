using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float groundWidth;
    BoxCollider2D box;
    
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        groundWidth = box.size.x;
    }

    
    void Update()
    {
        transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= -groundWidth) {
            transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
        }
    }
}
