using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region SystemsReferences
    InputManager inputManager;
    #endregion



    public void Awake()
    {
        
    }

    private void InitSystems()
    {
        inputManager = gameObject.AddComponent<InputManager>();
    }
}
