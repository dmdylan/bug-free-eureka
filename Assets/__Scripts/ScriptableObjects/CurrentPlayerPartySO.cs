using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Party Object", menuName = "Party Object")]
public class CurrentPlayerPartySO : ScriptableObject
{
    private List<Character> currentPlayerParty = new List<Character>();

    public List<Character> CurrentPlayerParty { get => currentPlayerParty; set => currentPlayerParty = value; }
}
