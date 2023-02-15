using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DICE.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] float speed = 5.6f;
        NavMeshAgent navMeshAgent;

        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            UpdateAnimator();
        }
        public void MoveTo()
        {
            navMeshAgent.destination = target.transform.position;
            navMeshAgent.speed = speed;
            navMeshAgent.isStopped = false;
        }
        private void UpdateAnimator()
        {
            Vector3 velocity = navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("ForwardMovement", speed);
        }
    }
}

