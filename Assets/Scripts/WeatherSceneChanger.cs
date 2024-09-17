using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeatherSceneChanger : MonoBehaviour
{
    private Dictionary<string, string> weatherSceneMap = new Dictionary<string, string>()
    {
        { "Clouds", "CloudyScene" },
        { "Rain", "RainyScene" },
        { "Snow", "SnowyScene" },
        // 
    };

    public void ChangeScene(string weatherCondition)
    {
        // Get the scene name corresponding to the weather condition
        string sceneName;
        if (weatherSceneMap.TryGetValue(weatherCondition, out sceneName))
        {
            // Load the scene using the scene name
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            // Handle the case where the weather condition is not found in the dictionary
            Debug.LogError($"Unknown weather condition: {weatherCondition}");
        }
    }
}
