using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatUI : MonoBehaviour
{
    [SerializeField] private Transform turnOrderParent;
    [SerializeField] private Transform characterPanelsParent;

    public Transform TurnOrderParent => turnOrderParent;
    public Transform CharacterPanelsParent => characterPanelsParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
