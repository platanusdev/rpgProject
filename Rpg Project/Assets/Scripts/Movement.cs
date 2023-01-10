using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    //[SerializeField] Transform target;

    Ray lastRay;

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToClick();  
            
        }
        UpdateAnimator();
        
    }
    void MoveToClick()
    {
        Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit =  Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
    void UpdateAnimator()
    {
        Vector3 velocity = GetComponent < NavMeshAgent>().velocity;
        Vector3 localVelocity= transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("movementSpeed",speed);
    }
}
