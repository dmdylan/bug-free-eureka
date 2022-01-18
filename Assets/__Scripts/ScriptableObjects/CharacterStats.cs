using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Stats", menuName = "Character Stats")]
public class CharacterStats : ScriptableObject
{
    [Header("Primary Stats")]
    [SerializeField] private int maxHealth;
    [SerializeField] private int maxEnergy;
    [SerializeField] private int maxStrength;
    [SerializeField] private int maxAbility;

    [Header("Secondary Stats")]
    [SerializeField] private int speed;
    [SerializeField] private float luck;

    [Header("Defensive Stats")]
    [SerializeField] private int dodge;
    [SerializeField] private int block;

    [Header("Current Stats")]
    [SerializeField] private int currentHealth;
    [SerializeField] private int currentEnergy;
    [SerializeField] private int currentStrength;
    [SerializeField] private int currentAbility;
    [SerializeField] private int currentSpeed;
    [SerializeField] private float currentLuck;
    [SerializeField] private int currentDodge;
    [SerializeField] private int currentBlock;

    //[Header("Stat Bonuses")]
    //[SerializeField] private float healthBonus;

    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int MaxEnergy { get => maxEnergy; set => maxEnergy = value; }
    public int MaxStrength { get => maxStrength; set => maxStrength = value; }
    public int MaxAbility { get => maxAbility; set => maxAbility = value; }
    public int Speed { get => speed; set => speed = value; }
    public float Luck { get => luck; set => luck = value; }
    public int Dodge { get => dodge; set => dodge = value; }
    public int Block { get => block; set => block = value; }
    public int CurrentHealth { get { return currentHealth; }  set { currentHealth = value; } }
    public int CurrentEnergy { get => currentEnergy; set => currentEnergy = value; }
    public int CurrentStrength { get => currentStrength; set => currentStrength = value; }
    public int CurrentAbility { get => currentAbility; set => currentAbility = value; }
    public int CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
    public float CurrentLuck { get => currentLuck; set => currentLuck = value; }
    public int CurrentDodge { get => currentDodge; set => currentDodge = value; }
    public int CurrentBlock { get => currentBlock; set => currentBlock = value; }
}
