using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PositionStatus
{
    Friendly,
    Enemy
}

public abstract class Character : MonoBehaviour, IComparer<Character>
{
    [SerializeField] protected CharacterStats stats;
    [SerializeField] protected List<Ability> abilities;
    [SerializeField] protected PositionStatus status;

    public CharacterStats Stats => stats;
    //public List<Ability> Abilities => abilities;
    public PositionStatus Status => status;

    // Start is called before the first frame update
    void Start()
    {
        CharacterSetup();
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

    public abstract void TakeDamage(int damageAmount);

    public int Compare(Character x, Character y)
    {
        return x.stats.Speed.CompareTo(y.stats.Speed);
    }

    private void OnMouseEnter()
    {
        var material = GetComponent<Renderer>();
        material.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        var material = GetComponent<Renderer>();
        material.material.color = Color.red;
    }
}
