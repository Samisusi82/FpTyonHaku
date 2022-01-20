using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /**
    private PlayerInput playerInput;

    // store our controls
    private InputAction jumpAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        jumpAction = playerInput.actions["Jump"];
        jumpAction.ReadValue<float>();


    }
    /**/
    
    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 move = playerControls.Land.Move.ReadValue<Vector2>();
        Debug.Log("Move");
        //playerControls.Land.Jump.ReadValue<float>();
        //if (playerControls.Land.Jump.ReadValue<float>() == 1);
        if (playerControls.Land.Jump.triggered) 
            Debug.Log("Jump");
    }
    
}
