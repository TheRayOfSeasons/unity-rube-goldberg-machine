using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManipulator
{
    public float time;
    protected bool triggered = false;

    public TimeManipulator(float time)
    {
        this.time = time;
    }

    public void Trigger()
    {
        if (this.triggered)
            return;
        this.triggered = true;
        Time.timeScale = this.time;
    }
}
