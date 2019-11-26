using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public bool discoActive;
    public Transform CamPos;
    public Collider[] viewedObjects;
    public float capsuleLength, capsuleRadius;
    public UnityEvent Reverse;
    public ChangeTheWorld[] GPEs;

    // Start is called before the first frame update
    void Awake()
    {
        GPEs = FindObjectsOfType<ChangeTheWorld>();
    }

    public void Activate()
    {
        discoActive = true;
    }

    public void Desactivate()
    {
        discoActive = false;
        foreach(ChangeTheWorld reverseEvent in GPEs)
        {
            reverseEvent.isChanged = false;
            reverseEvent.RevertChanges.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (discoActive)
        {
            //viewedObjects = Physics.OverlapCapsule(CamPos.position, CamPos.position + new Vector3(0, 0, capsuleLength), capsuleRadius);
            viewedObjects = Physics.OverlapCapsule(CamPos.position, CamPos.position + (CamPos.forward * capsuleLength), capsuleRadius);

            foreach (Collider viewedObjectsCol in viewedObjects)
            {
                if (viewedObjectsCol.gameObject.GetComponent<ChangeTheWorld>() && !viewedObjectsCol.gameObject.GetComponent<ChangeTheWorld>().isChanged)
                {
                    ChangeTheWorld compatibleObject = viewedObjectsCol.gameObject.GetComponent<ChangeTheWorld>();
                    compatibleObject.ChangeSomething.Invoke();
                    compatibleObject.isChanged = true;
                }
            }
        }
    }
    private void OnDrawGizmos()
    {
        if (discoActive)
        {
            Gizmos.DrawSphere(CamPos.position, capsuleRadius);
            Gizmos.DrawSphere(CamPos.position + (CamPos.forward * capsuleLength), capsuleRadius);
        }
    }
}
