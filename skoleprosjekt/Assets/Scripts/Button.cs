using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject Object;
    public bool pushed;

    public Animator anim;

    public Transform child;

    private void Start()
    {
        // child = this.transform.Find("Door");
        //anim = child.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision other)
    {
        pushed = true;
        Trigger(pushed);
    }


    void OnCollisionExit(Collision other)
    {
        pushed = false;
        Trigger(pushed);
    }

    void Trigger(bool pushed)
    {
        if (child.tag == "Door")
        {
            if (pushed)
            {
                anim.SetBool("Pushed", true);
            }
            else
            {
                anim.SetBool("Pushed", false);
            }
        }
    }
}
