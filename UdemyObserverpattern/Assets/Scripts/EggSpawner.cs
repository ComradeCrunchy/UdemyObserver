using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject medPrefab;
    public Terrain terrain;
    private TerrainData _terrainData;

    private void Start()
    {
        _terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg", 1, 5f);
        InvokeRepeating("CreateMedKit", 1, 5f);
    }

    private void CreateEgg()
    {
        int x = (int) Random.Range(0, _terrainData.size.x);
        int z = (int) Random.Range(0, _terrainData.size.z);
        Vector3 pos = new Vector3(x, 0 , z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject egg = Instantiate(eggPrefab, pos, Quaternion.identity);
        
    }

    private void CreateMedKit()
    {
        int x = (int) Random.Range(0, _terrainData.size.x);
        int z = (int) Random.Range(0, _terrainData.size.z);
        Vector3 pos = new Vector3(x, 0 , z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject med = Instantiate(medPrefab, pos, Quaternion.identity);  
    }
}
