using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendersSpawner : MonoBehaviour
{
    private Defender defender;

    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(GetSquareClicked());        
    }

    public void SetSelectedDefender(Defender selectedDefender)
    {
        defender = selectedDefender;
    }

    public void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var starDisplay = FindObjectOfType<StarDisplay>();
        var defenderCost = defender.GetStarsCost();
        if (starDisplay.HasEnoughStars(defenderCost))
        {
            SpawnDefender(gridPos);
            starDisplay.SpentStars(defenderCost);
        }
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float x = Mathf.RoundToInt(rawWorldPos.x);
        float y = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(x, y);
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        Defender def = Instantiate(defender, worldPos, Quaternion.identity) as Defender;
    }
}
