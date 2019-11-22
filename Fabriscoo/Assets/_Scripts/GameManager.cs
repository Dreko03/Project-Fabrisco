using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform CamPos;
    public Collider[] viewedObjects;
    public float capsuleLength, capsuleRadius;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        viewedObjects = Physics.OverlapCapsule(CamPos.position, CamPos.position + new Vector3(0, 0, capsuleLength), capsuleRadius);
        foreach (Collider viewedObjectsCol in viewedObjects)
        {
            if (viewedObjectsCol.gameObject.GetComponent<ChangeTheWorld>() && !viewedObjectsCol.gameObject.GetComponent<ChangeTheWorld>().isChanged)
            {
                viewedObjectsCol.gameObject.GetComponent<ChangeTheWorld>().isChanged = true;
            }
        }
    }
    private void OnDrawGizmos()
    {

        Gizmos.DrawSphere(CamPos.position, capsuleRadius);
        Gizmos.DrawSphere(CamPos.position + new Vector3(0, 0, capsuleLength), capsuleRadius);
    }
}
