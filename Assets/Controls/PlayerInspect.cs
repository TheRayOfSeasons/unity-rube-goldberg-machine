using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInspect : MonoBehaviour
{
    private PlayerInput playerInput;
    public InputAction inputAction;

    void OnEnable()
    {
        inputAction.Enable();
    }

    void OnDisable()
    {
        inputAction.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.actions["look"].started += context => {
            Debug.Log("I is pressed");
        };
        playerInput.actions["look"].performed += context => {
            Debug.Log("Nagawa na");
        };
        playerInput.actions["look"].canceled += context => {
            Debug.Log("Binitiwan mo ko");
        };

        inputAction.started += context => {
            Debug.Log(context);
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInput.actions["look"].ReadValue<float>() == 1f)
        {
            Debug.Log("Hold on! Baby hold on!");
        }
        Debug.Log(playerInput.actions["move"].ReadValue<Vector2>());
    }

    // void OnLook()
    // {
    //     Debug.Log("I is pressed");
    // }
}
