using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyRPG.Control;



    namespace MyRPG.Cam
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}

