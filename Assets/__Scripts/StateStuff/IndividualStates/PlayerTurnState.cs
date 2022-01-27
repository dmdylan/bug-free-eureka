using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public class PlayerTurnState : State
    {
        bool hasSelectedTarget = false;

        public PlayerTurnState(CombatManager combatManager) : base(combatManager)
        {
            combatManager.AttackButton.onClick.AddListener(() => combatManager.StartCoroutine(AttackButton()));
            combatManager.SkillButton.onClick.AddListener(() => combatManager.StartCoroutine(SkillButton()));
            combatManager.ItemButton.onClick.AddListener(() => combatManager.StartCoroutine(ItemButton()));
        }

        public override IEnumerator Start()
        {
            GameEventsManager.Instance.PlayerTurnStarted();
            yield break;
        }

        private IEnumerator AttackButton()
        {
            while (!hasSelectedTarget)
            {
                SelectTarget();
                yield return null;
            }

            yield return new WaitForSeconds(.2f);

            combatManager.CurrentTarget.TakeDamage(combatManager.CurrentCharacterTurn.Stats.CurrentStrength);

            yield return new WaitForSeconds(.5f);

            combatManager.ChangeToNewPlayerOrEnemyState();
        }

        private IEnumerator SkillButton()
        {
            yield return null;
        }

        private IEnumerator ItemButton()
        {
            yield return null;
        }

        public override IEnumerator End()
        {
            GameEventsManager.Instance.PlayerTurnFinished();
            yield break;
        }

        private void SelectTarget()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.TryGetComponent(out Character character))
                {
                    if (character.Status.Equals(PositionStatus.Enemy))
                    {
                        if (Input.GetMouseButtonUp(0))
                        {
                            combatManager.CurrentTarget = character;
                        }
                    }
                }
            }
        }
    }
}