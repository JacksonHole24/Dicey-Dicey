using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DICE.Movement;

namespace DICE.Control
{
    public class PlayerController : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Mover>().MoveTo();
        }
    }

}
