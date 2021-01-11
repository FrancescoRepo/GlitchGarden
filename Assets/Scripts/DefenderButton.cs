using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] private Defender defenderPrefab;

    void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        if (buttons != null)
        {
            foreach (var defenderButton in buttons)
            {
                defenderButton.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
            }
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefendersSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
