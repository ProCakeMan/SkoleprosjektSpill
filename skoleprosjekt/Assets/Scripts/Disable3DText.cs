using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable3DText : MonoBehaviour
{
    public Transform Text;

    bool isActive;

    List<bool> Active;

    public List<Transform> TextList;

    bool validTrigger = true;

    private void Start()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (validTrigger)
        {
            int i = 0;
            foreach (Transform txt in TextList)
            {
                txt.gameObject.SetActive(!txt.gameObject.activeSelf);
                i++;
            }
            validTrigger = false;
        }
    }
}
