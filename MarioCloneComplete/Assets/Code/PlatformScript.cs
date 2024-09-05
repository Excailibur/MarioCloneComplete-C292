using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [Header("Platform Settings")]
    [Space()]

    [Header("Platform Movement")]
    [SerializeField] private bool canMove = true;          // Whether the platform moves
    [SerializeField] private bool canMoveX = false;        // Whether the platform rotates
    [SerializeField] private bool canMoveY = false;        // Whether the platform rotates

    [Header("Movement Parameters")]
    [SerializeField] private float speed = 5f;              // The speed of the platform
    [SerializeField] private float distance = 5f;           // The distance the platform will move

    [Header("Platform Rotation")]
    [SerializeField] private bool canRotate = false;        // Whether the platform will rotate
    [SerializeField] private float rotationSpeed = 5f;      // The speed of the rotation

    private Vector2 startPosition;                          // The start position of the platform
    private bool moveRight = true;                          // Whether the platform moves right or left
    private bool moveUp = true;                             // Whether the platform moves up or down

    // Start is called before the first frame update
    void Start()
    {
        //Set the start position
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        LoopPlatform();
    }

    void LoopPlatform()
    {
        //Check if the platform is a moving platform
        if (!canMove) { return; }
        
        if (canMoveX)
        {
            LoopHorizontal();
        }

        if (canMoveY)
        {
            LoopVertical();
        }

        if (canRotate)
        {
            //RotatePlatform();
            RotatePlatform();
        }
    }

    void LoopHorizontal()
    {
        if (Vector2.Distance(startPosition, transform.position) >= distance)
        {
            //Toggle the move right
            moveRight = !moveRight;
        }

        //Move the platform right
        if (moveRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        //Move the platform left
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    void LoopVertical()
    {
        if (Vector2.Distance(startPosition, transform.position) >= distance)
        {
            //Toggle the move up
            moveUp = !moveUp;
        }

        //Move the platform up
        if (moveUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        //Move the platform down
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    void RotatePlatform()
    {
        transform.Rotate(0, 0, rotationSpeed*Time.deltaTime);
    }
}
