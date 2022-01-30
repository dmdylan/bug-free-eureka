using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Convert to gameobject for prefabs instead of character list
[CreateAssetMenu(fileName = "New Enemy List", menuName = "Enemy List")]
public class EnemyLists : ScriptableObject
{
    [SerializeField] private List<Character> enemyList;

    public List<Character> EnemyList => enemyList;
}
