using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using static System.Net.WebRequestMethods;

public class WeatherAPI : MonoBehaviour
{
    public string cityName;
    private const string API_URL = "https://api.openweathermap.org/data/2.5/weather/?units=metric&";
    private const string APP_ID = "appid=4c2821880694cd7534a7726dbb83bed0";

    public WeatherInfo retrievedInfo;
    public WeatherSceneChanger weatherSceneChanger;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FetchInfoByCityName());
    }

    IEnumerator FetchInfoByCityName()
    {
        string apiCall = $"{API_URL}q={cityName}&{APP_ID}";;
        //string apiCall = API_URL + "q=" + cityName + "&" + APP_ID;
        UnityWebRequest request = UnityWebRequest.Get(apiCall);

        yield return request.SendWebRequest();
        retrievedInfo = JsonUtility.FromJson<WeatherInfo>(request.downloadHandler.text);

        if (retrievedInfo.weather.Count > 0)
        {
            WeatherDetails weatherDetails = retrievedInfo.weather[0];
            string weatherCondition = weatherDetails.main; 
            weatherSceneChanger.ChangeScene(weatherCondition);
        }
    }
}
