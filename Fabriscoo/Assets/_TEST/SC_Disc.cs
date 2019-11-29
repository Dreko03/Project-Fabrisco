using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SC_Disc : MonoBehaviour
{
    public AudioSource[] AudioSources;
    public Animator[] ans;
    public AnimationState anims;
    public CircularDrive circularDrive;
    public float outAngle;

    // Start is called before the first frame update
    void Awake()
    {
        AudioSources = FindObjectOfType<GameManager>().AudioSources;
        ans = FindObjectsOfType<Animator>();
        outAngle = circularDrive.outAngle;
        circularDrive = GetComponent<CircularDrive>();
    }

    // Update is called once per frame
    public void Accelerate()
    {
        foreach (AudioSource As in AudioSources)
        {
            As.pitch = 1f;
        }

        foreach (Animator an in ans)
        {
            an.SetFloat("Multiplier", 1f);
        }
    }

    public void Decelerate()
    {
        foreach (AudioSource As in AudioSources)
        {
            As.pitch = -1f;
        }
        foreach (Animator an in ans)
        {
            an.SetFloat("Multiplier", -1f);
        }
    }
}
