using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Stats", menuName = "Character Stats")]
public class CharacterStats : ScriptableObject
{
    [Header("Primary Stats")]
    [SerializeField] private int health;
    [SerializeField] private int energy;

    [Header("Secondary Stats")]
    [SerializeField] private int vitality;
    [SerializeField] private int strength;
    [SerializeField] private int stamina;
    [SerializeField] private int dexterity;

    [Header("Other Stats")]
    [SerializeField] private int speed;
    [SerializeField] private int luck;

    [Header("Defensive Stats")]
    [SerializeField] private int dodge;
    [SerializeField] private int block;

    [Header("Stat Bonuses")]
    [SerializeField] private float healthBonus;

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = health + (vitality * (int)1) + (strength * (int)1);
        }
    }

    public int Energy => energy;
}
