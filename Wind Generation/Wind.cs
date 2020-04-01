using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public enum WindDirection { North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest }
    public WindDirection wind;

    public WaterMapGenerator Current;
    [Range(1, 10)]
    public int windstrength=1;

    private float Timer;
    private float currentTime;
    private int Direction;
    void Start()
    {
        currentTime = Time.time;
    }
    void Update()
    {
        Timer = Time.time;
        print(Timer+" "+wind);
        if (Timer >= currentTime + 60)
        {
            currentTime = Time.time;
            Direction = Random.Range(1, 8);
            switch (Direction)
            {
                case (1):
                    wind = WindDirection.North;
                    break;
                case (2):
                    wind = WindDirection.NorthEast;
                    break;
                case (3):
                    wind = WindDirection.East;
                    break;
                case (4):
                    wind = WindDirection.SouthEast;
                    break;
                case (5):
                    wind = WindDirection.South;
                    break;
                case (6):
                    wind = WindDirection.SouthWest;
                    break;
                case (7):
                    wind = WindDirection.West;
                    break;
                case (8):
                    wind = WindDirection.NorthWest;
                    break;
            }
        }
        switch (wind)
        {
            case (WindDirection.North):
                Current.UpdateCurrent(1, 0, windstrength);
                break;
            case (WindDirection.NorthEast):
                Current.UpdateCurrent(1, 1, windstrength);
                break;
            case (WindDirection.East):
                Current.UpdateCurrent(0,1, windstrength);
                break;
            case (WindDirection.SouthEast):
                Current.UpdateCurrent(-1, 1, windstrength);
                break;
            case (WindDirection.South):
                Current.UpdateCurrent(-1, 0, windstrength);
                break;
            case (WindDirection.SouthWest):
                Current.UpdateCurrent(-1, -1, windstrength);
                break;
            case (WindDirection.West):
                Current.UpdateCurrent(0, -1, windstrength);
                break;
            case (WindDirection.NorthWest):
                Current.UpdateCurrent(1, -1, windstrength);
                break;
        }
    }
}
