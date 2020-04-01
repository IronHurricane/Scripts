using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour
{
    public bool DayNightCycle = true;
    [Range(10,1440)]
    public float minutespercycle;
    public float DayIntensity = .7f;
    public float NightIntensity = .2f;
    public Color DayTint;
    public Color NightTint;
    public GameObject Day;
    public GameObject Night;
    Light daylightmap;
    Light nightlightmap;
    void Start()
    {
        daylightmap = Day.AddComponent<Light>();
        nightlightmap = Night.AddComponent<Light>();
        daylightmap.intensity = DayIntensity;
        nightlightmap.intensity = NightIntensity;
        daylightmap.color = DayTint;
        nightlightmap.color = NightTint;
        daylightmap.type = LightType.Directional;
        nightlightmap.type = LightType.Directional;
    }
    void Update()
    {
        if (DayNightCycle)
        {
            transform.Rotate(minutespercycle / 10000, 0, 0);
        }
    }
}
