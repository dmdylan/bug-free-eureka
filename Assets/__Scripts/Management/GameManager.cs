using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [SerializeField] private CharacterList playerParty;
    [SerializeField] private CharacterList enemyParty;
    [SerializeField] private EnemyLists earlyEnemies;
    [SerializeField] private EnemyLists midEnemies;
    [SerializeField] private EnemyLists lateEnemies;
    [SerializeField] private GameObject CombatUIPrefab;
    [SerializeField] private GameObject CombatManagerPrefab;

    private CombatUI combatUI;
    private CombatManager combatManager;

    public CombatUI CombatUI => combatUI;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    private void SubscribeToEvents()
    {
        
    }

    private void UnsubscribeFromEvents()
    {

    }

    #region Combat Methods

    public void CombatUISetup()
    {
        var ui = Instantiate(CombatUIPrefab);

        combatUI = ui.GetComponent<CombatUI>();
    }

    public void CombatManagerSetup()
    {
        var manager = Instantiate(CombatManagerPrefab);

        combatManager = manager.GetComponent<CombatManager>();

        combatManager.Init(playerParty, enemyParty);
    }

    public void SpawnEnemies()
    {

    }

    #endregion

    #region Character Party Methods

    public void AddCharacterToParty(GameObject character)
    {
        playerParty.CurrentCharacterList.Add(character);
    }

    //TODO: Might cause issues if there are multiple of one character
    public void RemoveCharacterFromParty(GameObject character)
    {
        playerParty.CurrentCharacterList.Remove(character);
    }

    #endregion
}
