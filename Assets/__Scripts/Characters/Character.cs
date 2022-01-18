using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected CharacterStats stats;
    [SerializeField] protected List<Ability> abilities;

    //public CharacterStats Stats => stats;
    //public List<Ability> Abilities => abilities;

    // Start is called before the first frame update
    void Start()
    {
        CharacterSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CharacterSetup()
    {
        stats.CurrentAbility = stats.MaxAbility;
        stats.CurrentBlock = stats.Block;
        stats.CurrentDodge = stats.Dodge;
        stats.CurrentEnergy = stats.MaxEnergy;
        stats.CurrentHealth = stats.MaxHealth;
        stats.CurrentLuck = stats.Luck;
        stats.CurrentSpeed = stats.Speed;
        stats.CurrentStrength = stats.MaxStrength;
    }
}
