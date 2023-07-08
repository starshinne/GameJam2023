using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaperPlane : MonoBehaviour
{
    // Start is called before the first frame update 
    public Rigidbody2D rb;
    [Header("Basic Data")]
    public float speed;
    public float jumpForce;
    public InputControl inputControl;

    private void Awake()
    {
        inputControl = new InputControl();
        rb = GetComponent<Rigidbody2D>();
      inputControl.Player.Jump.started += Jump;

    }
    private void OnEnable() {
        inputControl.Enable();
    }
    private void OnDisable() {
        inputControl.Disable();
    }
    private void Update()
    {
        planeMove();
      

    }

    private void planeMove()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void Jump(InputAction.CallbackContext context)
    {      
            rb.AddForce(transform.up*jumpForce,ForceMode2D.Impulse);       
    }

}
