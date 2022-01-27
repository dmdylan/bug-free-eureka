using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public class PlayerTurnState : State
    {
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
            yield break;
        }

        private IEnumerator SkillButton()
        {
            yield return null;
        }

        private IEnumerator ItemButton()
        {
            yield return null;
        }
    }
}