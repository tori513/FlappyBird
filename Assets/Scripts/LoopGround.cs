using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] 
    private float speed = 1f;
    [SerializeField] 
    private float width = 6f;

    SpriteRenderer groundSp;

    private Vector2 startSize;

    void Start()
    {
        groundSp = GetComponent<SpriteRenderer>();
        startSize = new Vector2(groundSp.size.x, groundSp.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        groundSp.size = new Vector2(groundSp.size.x + speed * Time.deltaTime, groundSp.size.y);

        if(groundSp.size.x > width)
        {
            groundSp.size = startSize;
        }
    }
}
