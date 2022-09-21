using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int walkSpeed = 3;
    [SerializeField] private int sprintSpeed = 6;
    private int currentSpeed;

    [SerializeField] private int walkForce = 20;
    [SerializeField] private int sprintForce = 30;
    private int currentMoveForce;

    [SerializeField] private int jumpForce = 100;

    [SerializeField] private float fallMultiplier = 2.5f;

    [SerializeField] private Transform body;

    private Rigidbody2D rigidBody;

    private Vector2 velocity;

    public bool movingRight;
    public bool movingLeft;
    public bool isJumping;
    public bool isSprinting;

    private bool isGrounded;

    private InputHandler inputHandler;

    private ICommand currentCommand;

    private void Start()
    {
        inputHandler = new InputHandler(new WalkRightCommand(), new WalkLeftCommand(), new JumpCommand(), new SprintCommand());
        rigidBody = GetComponent<Rigidbody2D>();
        currentMoveForce = walkForce;
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        currentCommand = inputHandler.HandleInput();
        currentCommand?.Execute(gameObject);
        Debug.Log(currentCommand);

        if(rigidBody.velocity.y < 0)
        {
            rigidBody.gravityScale = fallMultiplier;
        }
        else
        {
            rigidBody.gravityScale = 1;
        }
    }

    public void Move(int _dir)
    {
        if(Mathf.Abs(rigidBody.velocity.x) <= currentSpeed)
        {
            rigidBody.AddForce(currentMoveForce * new Vector2(_dir,0));
        }

        body.localScale = new Vector3(_dir,body.localScale.y,body.localScale.z);
    }

    public void Jump()
    {
        if(isGrounded)
        {
            rigidBody.AddForce(jumpForce * Vector2.up,ForceMode2D.Impulse);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x,rigidBody.velocity.y/2);
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        isGrounded = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = false;
    }

}
