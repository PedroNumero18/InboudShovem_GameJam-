using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Vector2 Movement;
    private PlayerInput playerinput;
    private InputAction moveAction;

    private void Awake()
    {
        playerinput = GetComponent<PlayerInput>();
        moveAction = playerinput.actions["TPDW"];
    }

    private void Update()
    {
        Movement = moveAction.ReadValue<Vector2>();
    }

}
