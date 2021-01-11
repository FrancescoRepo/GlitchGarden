using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] private int stars = 100;

    private Text starText;

    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HasEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpentStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
