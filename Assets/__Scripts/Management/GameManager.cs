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

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        CombatUISetup();
        SpawnCharacters();
        CombatManagerSetup();
    }

    private void SubscribeToEvents()
    {
        
    }

    private void UnsubscribeFromEvents()
    {

    }

    #region Combat Methods

    private void CombatUISetup()
    {
        var ui = Instantiate(CombatUIPrefab);

        combatUI = ui.GetComponent<CombatUI>();
    }

    private void CombatManagerSetup()
    {
        var manager = Instantiate(CombatManagerPrefab);

        combatManager = manager.GetComponent<CombatManager>();

        combatManager.Init(playerParty, enemyParty, combatUI.AttackButton, combatUI.SkillButton, combatUI.ItemButton);
    }

    //TODO: Currently is only set for a set of 3 characters each
    private void SpawnCharacters()
    {
        var spawnInfo = FindObjectOfType<SpawnPoints>();

        for (int i = 0; i < playerParty.CurrentCharacterList.Count; i++)
        {
            Instantiate(playerParty.CurrentCharacterList[i], spawnInfo.FriendlySpawnPoints[i].position, spawnInfo.FriendlySpawnPoints[i].rotation);
        }

        for (int i = 0; i < enemyParty.CurrentCharacterList.Count; i++)
        {
            Instantiate(enemyParty.CurrentCharacterList[i], spawnInfo.EnemySpawnPoints[i].position, spawnInfo.EnemySpawnPoints[i].rotation);
        }
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
