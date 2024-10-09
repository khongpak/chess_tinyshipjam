using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFinishFlag : MonoBehaviour
{
    [SerializeField] private Transform[] flagSpawnPoint;
    private int randomPoint;
    [SerializeField] GameObject finishFlag;

    private void Start()
    {
        randomPoint = Random.Range(0, flagSpawnPoint.Length-1);
        Debug.Log(flagSpawnPoint[randomPoint].position);
        Instantiate(finishFlag, flagSpawnPoint[randomPoint].transform.position, Quaternion.identity);
    }
    
}
