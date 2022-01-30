using StateStuff;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : StateMachine
{
    [SerializeField] private LayerMask characterLayerMask;
    private List<Character> enemies = new List<Character>();
    private List<Character> friendlies = new List<Character>();
    private List<Character> allCharacters = new List<Character>();
    private Queue<Character> turnOrder = new Queue<Character>();
    private Character currentTarget;
    private Character currentCharacterTurn;
    private Button attackButton;
    private Button skillButton;
    private Button itemButton;

    #region Getters and Setters

    public LayerMask CharacterLayerMask => characterLayerMask;
    public List<Character> Enemies { get => enemies; set => enemies = value; }
    public List<Character> Friendlies { get => friendlies; set => friendlies = value; }
    public List<Character> AllCharacters { get => allCharacters; set => allCharacters = value; }
    public Queue<Character> TurnOrder { get => turnOrder; set => turnOrder = value; }
    public Character CurrentTarget { get => currentTarget; set => currentTarget = value; }
    public Character CurrentCharacterTurn { get => currentCharacterTurn; set => currentCharacterTurn = value; }
    public Button AttackButton => attackButton;
    public Button SkillButton => skillButton;
    public Button ItemButton => itemButton;

    #endregion

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
        friendlies = GameManager.Instance.PlayerParty;
    }

    public IEnumerator SetNewTurnOrder()
    {
        currentCharacterTurn = turnOrder.Dequeue();

        yield return new WaitForSeconds(1f);

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
