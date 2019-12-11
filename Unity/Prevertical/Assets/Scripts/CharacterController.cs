using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    #region InputVariab
    public float horizontalInput;
    public float verticalInput;
    public bool jumpInput;
    #endregion

    #region MovementVariables
    Rigidbody rb;
    public float moveForce;
    public float jumpForce;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManager();
    }

    private void FixedUpdate() {
        rb.AddForce(new Vector3(verticalInput * -1, 0, horizontalInput) * moveForce, ForceMode.Force);
        Jump();
        ApplyNormalGravity();
    }

    void Jump() {
        if (jumpInput) {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
    

    void InputManager() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetKeyDown(KeyCode.Space);
    }

    void ApplyNormalGravity() {

    }
}
