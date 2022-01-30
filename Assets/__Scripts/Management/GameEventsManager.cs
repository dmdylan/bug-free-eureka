using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventsManager : MonoBehaviour
{
    private static GameEventsManager instance;
    public static GameEventsManager Instance => instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this; 
    }

    #region Combat Event Actions

    public event Action OnPlayerTurnStarted;
    public void PlayerTurnStarted() => OnPlayerTurnStarted?.Invoke();

    public event Action OnPlayerTurnFinished;
    public void PlayerTurnFinished() => OnPlayerTurnFinished?.Invoke();

    public event Action OnEnemyTurnStarted;
    public void EnemyTurnStarted() => OnEnemyTurnStarted?.Invoke();

    public event Action OnEnemyTurnFinished;
    public void EnemyTurnFinished() => OnEnemyTurnFinished?.Invoke();

    public event Action<Character> OnCharacterTurnFinished;
    public void CharacterTurnFinished(Character character) => OnCharacterTurnFinished?.Invoke(character);

    public event Action<Character> OnPlayerCharacterDefeated;
    public void PlayerCharacterDefeated(Character character) => OnPlayerCharacterDefeated?.Invoke(character);

    public event Action<Character> OnEnemyCharacterDefeated;
    public void EnemyCharacterDefeated(Character character) => OnEnemyCharacterDefeated?.Invoke(character);

    #endregion
}
