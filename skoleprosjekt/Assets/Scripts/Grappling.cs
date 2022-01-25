using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grappling : MonoBehaviour
{
    [SerializeField] public GameObject rayShit;
    [SerializeField] GameObject player;
    Rigidbody rb;
    
    float speed = 2f;

    private void Start() {
        rb = player.GetComponent<Rigidbody>();
    }

    public void OnGrapple(InputAction.CallbackContext ctx)
    {
        switch (ctx.phase)
        {
            case InputActionPhase.Performed:
                Debug.Log("Click");
                if (Physics.Raycast(rayShit.transform.position, rayShit.transform.forward, out RaycastHit hit)){
                    if(hit.transform.tag == "Grapple")
                        rb.AddForce((hit.transform.position - player.transform.position) * speed, ForceMode.Impulse);
                }
                break;
        }
    }


}
