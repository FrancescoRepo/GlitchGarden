using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    [SerializeField] private int lives = 5;
    [SerializeField] private int lifeTaken = 1;

    private Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= lifeTaken;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<Level>().LoadGameOverScreen();
        }
    }

    
}
