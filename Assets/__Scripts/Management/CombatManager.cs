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

    public void Init(CharacterList playerParty, CharacterList enemyParty)
    {
        this.playerParty = playerParty;
        this.enemyParty = enemyParty;
    }

    private void Start()
    {
        SetAllCharacterLists();
        SetState(new BeginState(this));
    }

    private void OnEnable()
    {
        if(GameManager.Instance.CombatUI != null)
        {
            attackButton = GameManager.Instance.CombatUI.AttackButton;
            skillButton = GameManager.Instance.CombatUI.SkillButton;
            itemButton = GameManager.Instance.CombatUI.ItemButton;
        }
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

    public IEnumerator SetNewTurnOrder()
    {
        currentCharacterTurn = turnOrder.Dequeue();

        yield return new WaitForSeconds(.5f);

        turnOrder.Enqueue(currentCharacterTurn);
    }

    public void ChangeToNewPlayerOrEnemyState()
    {
        if (currentCharacterTurn.Status.Equals(PositionStatus.Friendly))
        {
            SetState(new PlayerTurnState(this));
        }
        else
        {
            SetState(new EnemyTurnState(this));
        }
    }
}
