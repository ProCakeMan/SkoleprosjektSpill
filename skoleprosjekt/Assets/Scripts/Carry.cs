using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
    public bool pickedUp;

    bool portal;

    LayerMask groundMask = 8;

    GameObject Player;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }


    public void Pick()
    {
        if (!pickedUp)
        {
            pickedUp = true;
            if(this.transform.name == "Portal1" | this.transform.name == "Portal2")
            {
                this.gameObject.GetComponent<Portal>().packUp();
                portal = true;
            }
        }
        else
        {
            pickedUp = false;
        }
    }

    void FixedUpdate()
    {
        if (pickedUp)
        {
            transform.position = Player.GetComponent<Movement>().pickPoint.transform.position;
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(portal && other.gameObject.layer == groundMask) 
        {
            this.gameObject.GetComponent<Portal>().unPack();
        }
    }
}
