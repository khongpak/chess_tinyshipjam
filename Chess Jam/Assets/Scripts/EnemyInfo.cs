using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    
    [SerializeField] bool isHorizontal;
    private int enemyHealth = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public bool EnemyStatus()
    {
        return isHorizontal;
    }

   
}
