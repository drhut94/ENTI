using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerController : MonoBehaviour
{
    #region Managers
    CharacterController controller;
    InputManager inputManager;
    #endregion

    #region MovmentVariables

    [Header("Movment")]
    public float walkingSpeed;
    public float runningSpeed;
    public float acceleration;

    public float velocity;

    #endregion

    public void Start()
    {
        controller = GetComponent<CharacterController>();
        inputManager = GetComponent<InputManager>();
    }

    public void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        if (inputManager.runInput)
            velocity = Mathf.Lerp(velocity, runningSpeed, acceleration);
        else
            velocity = Mathf.Lerp(velocity, walkingSpeed, acceleration);


        controller.Move(inputManager.movmentAxis * velocity);
        controller.
    }
}
