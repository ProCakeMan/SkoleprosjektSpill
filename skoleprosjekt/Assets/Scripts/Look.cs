using UnityEngine;
using UnityEngine.InputSystem;

public class Look : MonoBehaviour
{

    public float sensX = 8f;
    public float sensY = 0.5f;

    [SerializeField] Transform playerCam;
    [SerializeField] Transform thirdPersonCam;
    [SerializeField] float xClamp = 85f;
    float xRotation = 0f;
    Vector2 looking;
    float lookX;
    float lookY;

    bool thirdperson;

    public bool doLooking = true;

    public void OnLook(InputAction.CallbackContext ctx)
    {
        if (doLooking)
        {
            Screen.lockCursor = true;
            looking = ctx.ReadValue<Vector2>();
            lookX = looking.x * sensX * Time.deltaTime;
            lookY = looking.y * sensY * Time.deltaTime;

            xRotation -= lookY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            playerCam.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            transform.Rotate(Vector3.up * lookX);
        }
        if (!doLooking)
            Screen.lockCursor = false;
    }


    public void On3rdPerson (InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                if(thirdperson)
                {
                    thirdperson = false;
                    playerCam.gameObject.SetActive(true);
                    thirdPersonCam.gameObject.SetActive(false);
                }
                else
                {
                    thirdperson = true;
                    playerCam.gameObject.SetActive(false);
                    thirdPersonCam.gameObject.SetActive(true);
                }
                break;
        }
    }
}
