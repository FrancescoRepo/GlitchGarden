using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private int defenderCost = 100;

    public int GetStarsCost()
    {
        return defenderCost;
    }
}
