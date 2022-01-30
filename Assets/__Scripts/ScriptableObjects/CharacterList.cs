using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character List Object", menuName = "Character List Object")]
public class CharacterList : ScriptableObject
{
    private List<Character> currentCharacterList = new List<Character>();

    public List<Character> CurrentCharacterList { get => currentCharacterList; set => currentCharacterList = value; }
}
