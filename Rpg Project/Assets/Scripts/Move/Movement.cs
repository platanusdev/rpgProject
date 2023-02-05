using MyRPG.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace MyRPG.Move
{
    public class Movement : MonoBehaviour
    {
        //[SerializeField] Transform target;
        NavMeshAgent navMesh;
        private void Start()
        {
            navMesh= GetComponent<NavMeshAgent>();
        }
        void Update()
        {
            UpdateAnimator();

        }
        public void StartMove(Vector3 destination)
        {
            GetComponent<Fighter>().Cancel();
            MoveTo(destination);    
        }
        public void MoveTo(Vector3 destination)
        {
            navMesh.destination = destination;
            navMesh.isStopped = false;
        }
        public void Stop()
        {
            navMesh.isStopped = true;
        }
        void UpdateAnimator()
        {
            Vector3 velocity = navMesh.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("movementSpeed", speed);
        }
    }
}
