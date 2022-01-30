using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy List", menuName = "Enemy List")]
public class EnemyLists : ScriptableObject
{
    [SerializeField] private List<Character> enemyList;

    public List<Character> EnemyList => enemyList;
}
