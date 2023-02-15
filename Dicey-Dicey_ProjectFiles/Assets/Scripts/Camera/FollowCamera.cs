using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DICE.Core
{
    public class FollowCamera : MonoBehaviour
    {

        [SerializeField] public Transform target;

        void Update()
        {
            transform.position = target.position;
        }
    }

}
