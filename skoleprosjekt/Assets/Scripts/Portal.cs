using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField] ParticleSystem ring;
    [SerializeField] ParticleSystem sparks;

    Rigidbody rb;

    Vector3 size;

    Quaternion rot;

    int rateOverTime;

    public bool active = false;

    public bool endLevel = false;

    bool entered = false;

    public Transform teleportPoint;

    public string scene;

    public GameObject portal2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        size = transform.localScale;
        rot = transform.rotation;
        ring.Stop();
        sparks.Stop();
        if(active)
        {
            makeActive();
        }
    }

    public void makeActive()
    {
        sparks.Play();
        ring.Play();
        var ringEmission = ring.emission;
        ringEmission.rateOverTime = 5;
        rateOverTime = 5;
        active = true;
        portal2.GetComponent<Portal>().makeActive();
    }

    public void disable()
    {
        sparks.Stop();
        ring.Stop();
        active = false;
        portal2.GetComponent<Portal>().disable();
    }

    private void Update()
    {
        if (active)
        {
            var ringEmission = ring.emission;
            if (rateOverTime < 500)
            {
                ringEmission.rateOverTime = rateOverTime + 50;
                rateOverTime = rateOverTime + 50;
            }
        }
    }

    public void packUp()
    {
        Debug.Log("Yes");
        this.transform.localScale = new Vector3(1f, 1f, 1f);
        rb.freezeRotation = false;
        rb.mass = 1f;
    }

    public void unPack()
    {
        this.transform.localScale = size;
        rb.freezeRotation = true;
        transform.rotation = rot;
        rb.mass = 100f;
        makeActive();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            if (!endLevel)
            {
                other.gameObject.transform.position = teleportPoint.position;
                disable();
            }
            if(endLevel)
            {
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
            }
        }
    }
}
