using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject prefabTest;

    public List<GameObject> gunOnMap;

    void Start()
    {
        
    }

    public void SpawnBlueSquare()
    {
        GameObject obj =  Instantiate(prefabTest, transform.position, Quaternion.identity);
        Destroy(obj, 2f);

    }

    
    
}
