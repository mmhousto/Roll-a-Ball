using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using System;

static public class CustomAnalytics
{

    static public void SendGameStart()
    {
        AnalyticsEvent.GameStart(new Dictionary<string, object>
        {
            {"time", DateTime.Now }
        });
    }

    static public void SendGameOver()
    {
        AnalyticsEvent.GameOver(null, new Dictionary<string, object>
        {
            {"time", DateTime.Now }
        });
    }


}
