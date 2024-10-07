using System;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    [SerializeField]
    TextMeshPro Country;
    [SerializeField]
    TextMeshProUGUI Time;
   
    public int timeChange = 0;
   
    DateTime getTime()
    {
        DateTime utcNow = DateTime.UtcNow;
        return utcNow.AddHours(timeChange);
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()   
    {
        Time.text = getTime().ToString();
        DateTime time = getTime();
    	hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TimeOfDay.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TimeOfDay.TotalMinutes);
		secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TimeOfDay.TotalSeconds);
    }
}
