using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "New Ability")]
public class AbilityInfo : ScriptableObject
{
    [Header("Ability Info")]
    [SerializeField] private string abilityName;
    [TextArea]
    [SerializeField] private string abilityDescription;

    [Header("Damage Stats")]
    [SerializeField] private int damage;

    [Header("Status Effect")]
    [SerializeField] private StatusEffect statusEffect;

    [Header("Ability Costs")]
    [SerializeField] private int energyCost;
    [SerializeField] private int cooldown;
    [SerializeField] private int cooldownRemaining;

    public string AbilityName => abilityName;
    public string AbilityDescription => abilityDescription;
    public int Damage => damage;
    public StatusEffect StatusEffect => statusEffect;
    public int EnergyCost => energyCost;
    public int Cooldown => cooldown;
    public int CooldownRemaining => cooldownRemaining;
}

public enum StatusEffect
{
    Stun,
    DoT,
    Heal,
    HoT,
    EnergyDrain
}
