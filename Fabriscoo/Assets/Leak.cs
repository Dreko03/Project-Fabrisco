using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leak : MonoBehaviour
{
    public ParticleSystem ps_leak;
    public Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ps_leak = GetComponent<ParticleSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        if (rb.isKinematic)
        {
            Debug.DrawRay(transform.position + new Vector3(0, 0.21f, 0), transform.up);
            Debug.Log("IsKinematic");
            Ray ray = new Ray(transform.position + new Vector3(0, 0.21f, 0), transform.up);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, 9))
            {
                Debug.Log("JE SUIS FACE AU SOL");
                ps_leak.Play();
            }
            else
            {
                Debug.Log("non");
                ps_leak.Stop();
            }
            //if (rb.worldCenterOfMass.y > 3f)
            //{
            //    Debug.Log("IsRENVERSED");
            //    ps_leak.Play();
            //}
            //else
            //{
            //    ps_leak.Stop();
            //}
        }
    }
}
