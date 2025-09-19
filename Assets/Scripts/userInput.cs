using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class userInput : MonoBehaviour
{
    public string startScene = "IntroScene00";
    public InputActionReference resetButton;
    void Start()
    {
        if (resetButton != null) resetButton.action.started += buttonWasPressed;
    }
    void buttonWasPressed(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(startScene);
    }
}
