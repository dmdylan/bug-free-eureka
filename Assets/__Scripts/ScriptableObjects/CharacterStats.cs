using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Stats", menuName = "Character Stats")]
public class CharacterStats : ScriptableObject
{
    [Header("Primary Stats")]
    [SerializeField] private int health;
    [SerializeField] private int energy;
    [SerializeField] private int strength;
    [SerializeField] private int ability;

    //[Header("Secondary Stats")]
    //[SerializeField] private int vitality;
    //[SerializeField] private int stamina;
    //[SerializeField] private int dexterity;

    [Header("Other Stats")]
    [SerializeField] private int speed;
    [SerializeField] private float luck;

    [Header("Defensive Stats")]
    [SerializeField] private int dodge;
    [SerializeField] private int block;

    //[Header("Stat Bonuses")]
    //[SerializeField] private float healthBonus;

    public int Health => health;
    public int Energy => energy;
    public int Strength => strength;
    public int Ability => ability;
    public int Speed => speed;
    public float Luck => luck;
    public int Dodge => dodge;
    public int Block => block;
}
