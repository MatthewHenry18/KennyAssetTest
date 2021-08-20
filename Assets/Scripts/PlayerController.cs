using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //making variable of type player action controls
    private PlayerActionControls playerActionControls;

    [SerializeField]private float speed, jumpSpeed, climbSpeed;
    
    [SerializeField] private LayerMask ground;
    [SerializeField] private LayerMask water;

    private Collider2D collider2D;

    private Rigidbody2D rb;
    void Awake()
    {
        //instanciating the variable 
        playerActionControls = new PlayerActionControls();
        rb = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();

    }
    //Enabling controls 
    private void OnEnable()
    {
        playerActionControls.Enable();
    }
    private void OnDisable()
    {
        playerActionControls.Disable();
    }
    void Start()
    {
        playerActionControls.LandMovement.Jump.performed += _ => Jump();
    }

    private void Jump()
    {
        if(IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= collider2D.bounds.extents.x;
        topLeftPoint.y += collider2D.bounds.extents.y;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += collider2D.bounds.extents.x;
        bottomRightPoint.y -= collider2D.bounds.extents.y;

        return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, ground);
    }
    private bool IsUnderwater()
    {
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= collider2D.bounds.extents.x;
        topLeftPoint.y += collider2D.bounds.extents.y;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += collider2D.bounds.extents.x;
        bottomRightPoint.y -= collider2D.bounds.extents.y;

        return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, water);
    }

    // Update is called once per frame
    void Update()
    {
        //read input from keyvboard action bindings
        float horizontalmovementInput = playerActionControls.LandMovement.Move.ReadValue<float>();
        float climbingInput = playerActionControls.LandMovement.Climb.ReadValue<float>();

        //animation
        if(IsUnderwater() && climbingInput != 0)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;

            Debug.Log("IsClimbing");
            GetComponent<Animator>().SetBool("IsRunning", true);
            Vector3 currentPosition = transform.position;
            currentPosition.y += climbingInput * climbSpeed * Time.deltaTime;
            transform.position = currentPosition;         
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if (horizontalmovementInput != 0)
        {
            GetComponent<Animator>().SetBool("IsRunning", true);
            //Debug.Log("IsRunning");
            //turns the player the correct direction 
            if(horizontalmovementInput > 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            //move the player
            Vector3 currentPosition = transform.position;
            currentPosition.x += horizontalmovementInput * speed * Time.deltaTime;
            transform.position = currentPosition;
        }
        else
        {
            GetComponent<Animator>().SetBool("IsRunning", false);
            Debug.Log("NotRunning");
        }

       

    }
}
