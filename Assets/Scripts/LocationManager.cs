using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    private void Start()
    {
        
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("Location service is not enabled by the user.");
            return;
        }

        Input.location.Start();

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            // wait for 1 second
            maxWait--;
            System.Threading.Thread.Sleep(1000);
        }

        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            return;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            return;
        }

        else
        {
            
            Debug.Log("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
        }

        Input.location.Stop();
    }
}
