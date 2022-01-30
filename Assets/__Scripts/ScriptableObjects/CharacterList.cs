using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character List Object", menuName = "Character List Object")]
public class CharacterList : ScriptableObject
{
    [SerializeField] private List<GameObject> currentCharacterList = new List<GameObject>();

    public List<GameObject> CurrentCharacterList { get => currentCharacterList; set => currentCharacterList = value; }
}
