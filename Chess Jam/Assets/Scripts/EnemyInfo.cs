using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    public static EnemyInfo instance;
    [SerializeField] bool isHorizontal;
    public bool isMove;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public bool EnemyStatus()
    {
        return isHorizontal;
    }

   
}
