using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInput : MonoBehaviour
{
    private PlayerInput playerInput;

    void OnFire()
    {
        Debug.Log("On Fire");
    }

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        // playerInput.actions["fire"].started += context => {
        //     Debug.Log("On Fire");
        // };
        playerInput.actions["fire"].canceled += context => {
            Debug.Log("Fire released");
        };
    }

    void Update()
    {
        if (playerInput.actions["fire"].ReadValue<float>() == 1f)
        {
            Debug.Log("Hold Fire");
        }
    }
}
