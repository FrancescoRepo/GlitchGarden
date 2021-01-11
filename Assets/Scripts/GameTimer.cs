using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float levelTime = 10;

    private Slider timeSlider;

    void Start()
    {
        timeSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSlider.value = Time.timeSinceLevelLoad / levelTime;
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        if (timerFinished)
        {

        }
    }
}
