using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [SerializeField] private CurrentPlayerPartySO playerParty;
    [SerializeField] private GameObject CombatUIPrefab;
    [SerializeField] private GameObject CombatManagerPrefab;

    private CombatUI combatUI;
    private CombatManager combatManager;

    public List<Character> PlayerParty => playerParty.CurrentPlayerParty;
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
    }

    #endregion

    #region Character Party Methods

    public void AddCharacterToParty(Character character)
    {
        playerParty.CurrentPlayerParty.Add(character);
    }

    //TODO: Might cause issues if there are multiple of one character
    public void RemoveCharacterFromParty(Character character)
    {
        playerParty.CurrentPlayerParty.Remove(character);
    }

    #endregion
}
