using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefab;
    public Terrain terrain;
    private TerrainData _terrainData;
    public Event eggDrop;

    private void Start()
    {
        _terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg", 1, 20f);
    }

    private void CreateEgg()
    {
        int x = (int) Random.Range(0, _terrainData.size.x);
        int z = (int) Random.Range(0, _terrainData.size.z);
        Vector3 pos = new Vector3(x, 0 , z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject egg = Instantiate(eggPrefab, pos, Quaternion.identity);
        eggDrop.Occured(egg);
    }
}
