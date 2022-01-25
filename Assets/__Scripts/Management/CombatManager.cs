using StateStuff;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : StateMachine
{
    private List<Character> enemies = new List<Character>();
    private List<Character> friendlies = new List<Character>();
    private List<Character> allCharacters = new List<Character>();
    private Queue<Character> turnOrder = new Queue<Character>();
    private Character currentTarget;
    private Character currentCharacterTurn;
    [SerializeField] private GameObject CombatUI;

    #region Getters and Setters

    public List<Character> Enemies { get => enemies; set => enemies = value; }
    public List<Character> Friendlies { get => friendlies; set => friendlies = value; }
    public List<Character> AllCharacters { get => allCharacters; set => allCharacters = value; }
    public Queue<Character> TurnOrder { get => turnOrder; set => turnOrder = value; }
    public Character CurrentTarget { get => currentTarget; set => currentTarget = value; }
    public Character CurrentCharacterTurn { get => currentCharacterTurn; set => currentCharacterTurn = value; }

    #endregion

    private void Start()
    {
        friendlies = GameManager.Instance.PlayerParty;
        SetState(new BeginState(this));
    }
}
