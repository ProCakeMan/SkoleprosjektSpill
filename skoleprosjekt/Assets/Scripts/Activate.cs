using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public enum Objects {Door, Other};
    private Animator anim;
    public Objects Object; 

    public void Start(){
        anim = GetComponent<Animator>();
    }

    public void Trigger(bool pushed)
    {
        if(Object == Objects.Door){
            if(pushed)
            {
                //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 3.0f, this.transform.position.z);
                anim.SetBool("Pushed", true);
            }
            if(!pushed)
            {
                anim.SetBool("Pushed", false);
            }
        }
    }
    
}
