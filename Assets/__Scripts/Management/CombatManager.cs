using StateStuff;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : StateMachine
{
    private CharacterList playerParty;
    private CharacterList enemyParty;

    private List<Character> allCharacters = new List<Character>();
    private Queue<Character> turnOrder = new Queue<Character>();
    private Character currentTarget;
    private Character currentCharacterTurn;
    private Button attackButton;
    private Button skillButton;
    private Button itemButton;

    #region Getters and Setters

    public CharacterList PlayerParty => playerParty;
    public CharacterList EnemyParty => enemyParty;
    public List<Character> AllCharacters { get => allCharacters; set => allCharacters = value; }
    public Queue<Character> TurnOrder { get => turnOrder; set => turnOrder = value; }
    public Character CurrentTarget { get => currentTarget; set => currentTarget = value; }
    public Character CurrentCharacterTurn { get => currentCharacterTurn; set => currentCharacterTurn = value; }
    public Button AttackButton => attackButton;
    public Button SkillButton => skillButton;
    public Button ItemButton => itemButton;

    #endregion

    public void Init(CharacterList playerParty, CharacterList enemyParty, Button attackButton, Button skillButton, Button itemButton)
    {
        this.playerParty = playerParty;
        this.enemyParty = enemyParty;
        this.attackButton = attackButton;
        this.skillButton = skillButton;
        this.itemButton = itemButton;
    }

    private void Start()
    {
        SetAllCharacterLists();
        StartCoroutine(SetState(new BeginState(this)));
    }

    private void Update()
    {
        Debug.Log(state);
        state.UpdateState();
    }

    private void SetAllCharacterLists()
    {
        foreach(GameObject gameObject in playerParty.CurrentCharacterList)
        {
            allCharacters.Add(gameObject.GetComponent<Character>());
        }

        foreach(GameObject enemy in enemyParty.CurrentCharacterList)
        {
            allCharacters.Add(enemy.GetComponent<Character>());
        }
    }

    public void SetNewTurnOrder()
    {
        currentCharacterTurn = turnOrder.Dequeue();
        turnOrder.Enqueue(currentCharacterTurn);
    }

    public void ChangeToNewPlayerOrEnemyState()
    {
        SetNewTurnOrder();

        if (currentCharacterTurn.Status.Equals(PositionStatus.Friendly))
        {
            StartCoroutine(SetState(new PlayerTurnState(this)));
        }
        else
        {
            StartCoroutine(SetState(new EnemyTurnState(this)));
        }
    }
}
