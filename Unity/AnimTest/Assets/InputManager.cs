using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    
    public Vector3 movmentAxis;
    public bool runInput;

    public void Update()
    {
        movmentAxis = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));

        if (Input.GetKey(KeyCode.LeftShift))
        {
            runInput = true;
        }
        else
        {
            runInput = false;
        }
    }
}
