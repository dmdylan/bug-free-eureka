using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State state;

        public void SetState(State state)
        {
            this.state = state;
            StartCoroutine(state.Start());
        }
    }
}