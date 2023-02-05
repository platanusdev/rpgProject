using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyRPG.Move;

namespace MyRPG.Combat
{
    
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;
        Transform target;
        private void Update()
        {
            if (target == null) { return; }
            
            if (target!= null && !GetIsInRange())
            {
                GetComponent<Movement>().MoveTo(target.position);  
            }
            else
            {
                GetComponent<Movement>().Stop();
            }
        }
        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, target.position) < weaponRange;
        }

        public void Attack(CombatTarget combattarget)
        {
            target = combattarget.transform;
            Debug.Log("Nice, thats Enemy");
        }
        public void Cancel()
        {
            target = null;
        } 


    }
}
