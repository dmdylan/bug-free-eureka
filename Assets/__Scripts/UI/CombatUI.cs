using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatUI : MonoBehaviour
{
    [SerializeField] private Transform turnOrderParent;
    [SerializeField] private Transform characterPanelsParent;
    [SerializeField] private Button attackButton;
    [SerializeField] private Button skillButton;
    [SerializeField] private Button itemButton;

    public Transform TurnOrderParent => turnOrderParent;
    public Transform CharacterPanelsParent => characterPanelsParent;
    public Button AttackButton => attackButton;
    public Button SkillButton => skillButton;
    public Button ItemButton => itemButton;
}
