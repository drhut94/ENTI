using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class InputManager : MonoBehaviour
{
    #region Singleton
    public static InputManager instance;

    public void Awake() {
        if(instance == null) {
            instance = this;
        }
        else
            Destroy(instance);


    }
    #endregion
    

}
