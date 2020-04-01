using UnityEngine;
using System.Collections;

public class WaterMapGenerator : MonoBehaviour
{

    public enum DrawMode { Mesh };
    public DrawMode drawMode;

    public Texture2D texture;
    public int mapWidth;
    public int mapHeight;
    public float noiseScale;
    public float heightmultiplier;

    public int octaves;
    [Range(0, 1)]
    public float persistance;
    public float lacunarity;

    public int seed;
    public Vector2 offset=new Vector2(0,0);

    public bool autoUpdate;

    public void UpdateCurrent(float x, float y, int Intensity)
    {
        offset = new Vector2(offset[0] + (x*Intensity)/20, offset[1] + (y*Intensity)/20);
        if (x != 0) { heightmultiplier = 5 * x; }
        else if (y != 0) { heightmultiplier = 5 * y; }

        GenerateMap();
    }
    public void GenerateMap()
    {
        float[,] noiseMap = WaterNoise.GenerateNoiseMap(mapWidth, mapHeight, seed, noiseScale, octaves, persistance, lacunarity, offset);

        WaterMapDisplay display = FindObjectOfType<WaterMapDisplay>();
        if (drawMode == DrawMode.Mesh)
        {
            display.DrawMesh(WaterMeshGenerator.GenerateTerrainMesh(noiseMap, heightmultiplier), texture);
        }
    }

    void OnValidate()
    {
        if (mapWidth < 1)
        {
            mapWidth = 1;
        }
        if (mapHeight < 1)
        {
            mapHeight = 1;
        }
        if (lacunarity < 1)
        {
            lacunarity = 1;
        }
        if (octaves < 0)
        {
            octaves = 0;
        }
    }
}