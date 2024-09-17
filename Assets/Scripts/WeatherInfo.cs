using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeatherInfo
{
    public string name;
    public string timezone;
    public Main main;
    public List<WeatherDetails> weather;
    public Wind wind;
}
[System.Serializable]
public class Main
{
    public string temp;
    public string feels_like;
}
[System.Serializable]
public class WeatherDetails
{
    public int id;
    public string main;
    public string description;
    public string icon;
}
[System.Serializable]
public class Wind
{
    public string speed;
    public string deg;
}

