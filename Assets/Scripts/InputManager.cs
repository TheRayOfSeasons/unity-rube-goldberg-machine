using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private InputAction playerInput;

    private void OnEnable()
    {
        if (playerInput != null)
        {
            playerInput.Enable();
        }
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerInput = new InputAction(
            type: InputActionType.Button,
            binding: "<Keyboard>/x",
            interactions: "press(behavior=1)");
        playerInput.Enable();

        playerInput.started += context => {
            Debug.Log("started");
        };
        playerInput.performed += context => {
            Debug.Log("performed");
        };
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(playerInput.ReadValue<float>());
    }
}
