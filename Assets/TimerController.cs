using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    //TODO: Thread safe!!!
    public static TimerController Instance;
    public static bool Enabled;
    private static DateTime start;
    private static TimeSpan time;

    public static bool TryStart()
    {
        if (Enabled) return false;
        if (time.TotalMilliseconds != 0) return false;
        start = DateTime.Now;
        Enabled = true;
        return true;
    }
    public static bool TryStop()
    {
        if (!Enabled) return false;
        if (time.TotalSeconds < 5) return false;
        Enabled = false;
        return true;
    }

    void Update()
    {
        var textField = this.gameObject.GetComponent<Text>();
        if (Enabled) time = DateTime.Now - start;
        textField.text = time.Minutes.ToString().PadLeft(2, '0') + ":" + time.Seconds.ToString().PadLeft(2, '0');
    }
}
