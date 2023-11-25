using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objectPrefab;
    public int spawnCount;
    public Vector3 objectPosition;

    private void Start()
    {
        for(int i = 0; i < spawnCount; i++)
        {
            GameObject obj = Instantiate(objectPrefab, new Vector3(Random.Range(-100, 100), //random x
                                                        Random.Range(-100, 100), //random y
                                                        objectPrefab.transform.position.z), //original prefab z
                                                        Quaternion.identity); //keep original prefab rotation
            Debug.Log("Fuel tank at " + obj.transform.position.ToString());
        }
    }
}
