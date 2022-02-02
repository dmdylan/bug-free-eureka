using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private List<Transform> friendlySpawnPoints;
    [SerializeField] private List<Transform> enemySpawnPoints;

    public List<Transform> FriendlySpawnPoints => friendlySpawnPoints;
    public List<Transform> EnemySpawnPoints => enemySpawnPoints;
}
