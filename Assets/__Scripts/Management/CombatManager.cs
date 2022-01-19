using StateStuff;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : StateMachine
{
    static CombatManager instance;
    public static CombatManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<CombatManager>();
            return instance;
        }
    }

    private List<Character> enemies = new List<Character>();
    private List<Character> friendlies = new List<Character>();
    private List<Character> allCharacters = new List<Character>();
    private Queue<Character> turnOrder = new Queue<Character>();
    private GameObject currentTarget;

    public GameObject CurrentTarget => currentTarget;

    private void Start()
    {
        SeparateFriendsAndEnemies();
        SetTurnOrder();

        SetState(new BeginState(this));
    }

    private void SeparateFriendsAndEnemies()
    {
        foreach(Character character in allCharacters)
        {
            if(character.Status == PositionStatus.Enemy)
                enemies.Add(character);
            else
                friendlies.Add(character);
        }
    }

    private void SetTurnOrder()
    {
        List<Character> sortedList = allCharacters;
        sortedList.Sort((IComparer<Character>)allCharacters);
        
        foreach(Character character in sortedList)
        {
            turnOrder.Enqueue(character);
        }
    }
}
