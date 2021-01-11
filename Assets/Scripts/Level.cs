using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private int currentIndex;

    void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex == 0)
        {
            StartCoroutine(ShowStartScreen());
        }
    }

    private IEnumerator ShowStartScreen()
    {
        yield return new WaitForSeconds(2);
        LoadStartScreen();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(++currentIndex);
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGameOverScreen()
    {
        SceneManager.LoadScene(3);
    }
}
