using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    #region InputVariables
    public float horizontalInput;
    public float verticalInput;
    public bool jumpInput;
    private bool horizontalDown;
    private bool verticalDown;
    #endregion

    #region MovementVariables
    Rigidbody rb;
    public float moveForce;
    public float jumpForce;
    private Vector3 normalVector;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        normalVector = new Vector3(0, 1, 0);
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

        //if (!horizontalDown) {
        //    if(rb.velocity.z > 0) {
        //        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Mathf.Lerp(rb.velocity.z, 0, 0.5f));
        //    }
        //}
        //if (!verticalDown) {
        //    if (rb.velocity.x > 0) {
        //        rb.velocity = new Vector3(rb.velocity.x, Mathf.Lerp(rb.velocity.y, 0, 0.5f), rb.velocity.z);
        //    }
        //}
    }

    void Jump() {
        if (jumpInput) {
            rb.AddForce(normalVector * jumpForce, ForceMode.Impulse);
        }
    }
    

    void InputManager() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 
        jumpInput = Input.GetKeyDown(KeyCode.Space);
        if(horizontalInput != 0) {
            horizontalDown = true;
        }
        else {
            horizontalDown = false;
        }
        if (verticalInput != 0) {
            verticalDown = true;
        }
        else {
            verticalDown = false;
        }
    }

    void ApplyNormalGravity() {
        rb.AddForce(normalVector * -9.81f); 
    }

    public void OnCollisionStay(Collision collision) {
        if(collision.contacts.Length <= 1) {
            normalVector = collision.contacts[0].normal.normalized;
          
            //transform.up = normalVector;
        }
        else {
            normalVector = collision.contacts[collision.contacts.Length - 1].normal.normalized;
        }

    }

    private void OnDrawGizmos() {
        if (normalVector != null) {
            Vector3 forward = Vector3.forward;

            Vector3 right = Vector3.Cross(forward, normalVector);

            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, transform.position + normalVector * 2.0f);
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + right * 2.0f);
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, transform.position + forward * 2.0f);
            //Cambiar 2 componentes i de las 3 cambiar de signo
        }
    }


}
