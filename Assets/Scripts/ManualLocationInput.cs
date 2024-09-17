using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualLocationInput : MonoBehaviour
{
    // Add these two fields to input latitude and longitude in the Inspector
    public float latitude;
    public float longitude;

    private void Start()
    {
        // Use the input latitude and longitude values here
        Debug.Log("Latitude: " + latitude + ", Longitude: " + longitude);
        // ...
    }
}
