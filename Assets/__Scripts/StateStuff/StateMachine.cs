using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State state;

        public IEnumerator SetState(State state)
        {
            if (this.state != null)
            {
                StartCoroutine(this.state.End());

                yield return new WaitUntil(() => this.state.CanChangeStates);
            }

            this.state = state;

            StartCoroutine(state.Start());
        }
    }
}