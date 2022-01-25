using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField] Rigidbody rb;
    [SerializeField] public Camera cam;
    [SerializeField] public GameObject pickPoint;

    [SerializeField] public GameObject rayShit;
    public float speed = 10f;
    public float overrideSpeed = 10f;
    Vector3 horizontalInput;
    Vector2 inputVec;

    public float jumpHeight = 10f;
    bool jump;
    bool isPickedUp;
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] int groundMask = 8;
    [SerializeField] int wallRunMask = 12;
    [SerializeField] LayerMask bounceMask;

    public GameObject pauseMenu;

    GameObject pickedUpObject;
    bool isGrounded;
    bool isBounce;

    SphereCollider groundCheck;

    [SerializeField] PhysicMaterial physicsMaterial;

    bool crouching;

    public bool uiOpen;

    bool isWallRunning = false;

    bool isGroundedOnWallRun = false;

    public GameObject ui;

    public Look look;


    private void Start()
    {
        groundCheck = transform.GetChild(0).GetComponent<SphereCollider>();
    }


    // Check if grounded
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == groundMask)
            isGrounded = true;

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            isGroundedOnWallRun = true;
            isWallRunning = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            isGroundedOnWallRun = false;
            isWallRunning = false;
        }
    }


    void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }

    private void Update()
    {
        isBounce = Physics.CheckSphere(transform.position, 1f, bounceMask);

        if (isBounce)
        {
            rb.AddForce(new Vector3(0, jumpHeight * 2, 0), ForceMode.Impulse);
            isBounce = false;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(
            Mathf.Clamp(rb.velocity.x, -15f, 15f),
            rb.velocity.y,
            Mathf.Clamp(rb.velocity.z, -15f, 15f)
        );
        if (crouching)
        {
            speed = overrideSpeed / 2;
        }
        else if (isWallRunning)
        {
            speed = overrideSpeed * 2.5f;
        }
        else
        {
            speed = overrideSpeed;
        }
        Vector3 dir = rb.rotation * horizontalInput;
        Vector3 movement = (dir * speed);
        rb.AddForce(new Vector3(movement.x, 0f, movement.z), ForceMode.Force);
    }
    public void OnMove(InputAction.CallbackContext ctx)
    {
        inputVec = ctx.ReadValue<Vector2>();
        horizontalInput = new Vector3(inputVec.x, 0f, inputVec.y);
        horizontalInput.Normalize();
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                jump = true;
                if (isGrounded || isGroundedOnWallRun)
                {
                    rb.AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode.Impulse);
                }
                break;
            case InputActionPhase.Canceled:
                jump = false;
                break;
        }
    }

    public void OnPickup(InputAction.CallbackContext ctx)
    {

        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                if (Physics.Raycast(rayShit.transform.position, rayShit.transform.forward, out RaycastHit hit))
                {
                    Debug.Log(hit.transform.tag);
                    switch (hit.transform.tag)
                    {
                        case "PickUp":
                            hit.transform.GetComponent<Carry>().Pick();
                            isPickedUp = hit.transform.GetComponent<Carry>().pickedUp;
                            pickedUpObject = hit.transform.gameObject;
                            break;
                        case "Puzzle":
                            hit.transform.GetComponent<Keypad>().Run(look);
                            ui = hit.transform.gameObject;
                            uiOpen = true;
                            break;
                    }
                }
                else if (isPickedUp)
                {
                    switch (pickedUpObject.transform.tag)
                    {
                        case "PickUp":
                            pickedUpObject.transform.GetComponent<Carry>().Pick();
                            isPickedUp = pickedUpObject.transform.GetComponent<Carry>().pickedUp;
                            pickedUpObject = null;
                            break;
                    }
                }
                break;
        }
    }

    public void OnScroll(InputAction.CallbackContext ctx)
    {
        Vector2 scrollValue = ctx.ReadValue<Vector2>().normalized;
        Vector3 scrollValue3 = new Vector3(scrollValue.x, 0f, scrollValue.y);
        if(isPickedUp)
        {
            Vector3 newPos = (rb.rotation * scrollValue3);
            pickPoint.transform.position = pickPoint.transform.position + newPos;
        }
    }

    public void OnCloseUI(InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                Debug.Log(uiOpen);
                Debug.Log(ui);
                if (uiOpen)
                {
                    Debug.Log(ui.transform.tag);
                    switch (ui.transform.tag)
                    {
                        case "Puzzle":
                            ui.GetComponent<Keypad>().Close();
                            look.doLooking = true;
                            ui = null;
                            uiOpen = false;
                            break;

                        case "Pause":
                            pauseMenu.GetComponent<PauseMenu>().Close();
                            look.doLooking = true;
                            ui = null;
                            uiOpen = false;
                            break;
                    }
                }
                else
                {
                    Debug.Log("PAUSE");
                    pauseMenu.GetComponent<PauseMenu>().Run(look);
                    uiOpen = true;
                    ui = pauseMenu;
                    Debug.Log(ui + " ui");
                    Debug.Log(uiOpen + " uiopen");
                }
                break;
        }
    }

    public void OnCrouch(InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                crouching = true;
                Debug.Log("crouch");
                transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
                if (isGrounded)
                {
                    rb.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse);
                    rb.velocity = rb.velocity * 1.2f;
                }
                physicsMaterial.dynamicFriction = 0.4f;
                physicsMaterial.bounciness = 1f;
                break;
            case InputActionPhase.Canceled:
                crouching = false;
                Debug.Log("stop crouch");
                transform.localScale = new Vector3(transform.localScale.x, 1f, transform.localScale.z);
                physicsMaterial.dynamicFriction = 0.7f;
                physicsMaterial.bounciness = 0f;
                break;
        }

    }

    public void SavePlayer()
    {
        SavingSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SavingSystem.LoadPlayer();

        look.sensX = data.sensX;
        look.sensY = data.sensY;
        transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);
    }
}
