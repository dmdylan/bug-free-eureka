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

    private CombatUI combatUI;

    public List<Character> PlayerParty => playerParty.CurrentPlayerParty;
    public CombatUI CombatUI => combatUI;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    #region Combat UI Methods

    public void CombatUISetup()
    {
        var ui = Instantiate(CombatUIPrefab);

        combatUI = ui.GetComponent<CombatUI>();
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

    //TODO: Make own game events class?
    #region Events

    public event Action OnCombatTurnFinished;

    #endregion
}
