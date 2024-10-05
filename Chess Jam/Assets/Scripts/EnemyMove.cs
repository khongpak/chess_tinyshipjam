using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    public static EnemyMove Instance;

    public float enemyMovePoint;
    public float enemyMoveStep;
    public GameObject[] enemyPawn;
    public EnemyInfo enemyPawnInfo;
    public int randomEnemyNumber;

    private bool reverst = false;
    Vector3 currentPosition;


    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        currentPosition = enemyPawn[randomEnemyNumber].transform.position;
           
    }
    public void Move()
    {
        RanddomEnemy();
        enemyPawnInfo = enemyPawn[randomEnemyNumber].GetComponent<EnemyInfo>(); 

        //EnemyPawn Move if Enemey Pawn Horizontal is true 
        if (enemyPawnInfo.EnemyStatus())
        {
            if (!reverst)
            {
                if (enemyPawn[randomEnemyNumber].transform.position.x < currentPosition.x + enemyMovePoint)
                {
                    enemyPawn[randomEnemyNumber].transform.position = new Vector3(enemyPawn[randomEnemyNumber].transform.position.x + enemyMoveStep, enemyPawn[randomEnemyNumber].transform.position.y, enemyPawn[randomEnemyNumber].transform.position.z);
                }
                else
                {
                    reverst = true;
                }
            }
            else
            {
                if (enemyPawn[randomEnemyNumber].transform.position.x > currentPosition.x - enemyMovePoint)
                {
                    enemyPawn[randomEnemyNumber].transform.position = new Vector3(enemyPawn[randomEnemyNumber].transform.position.x - enemyMoveStep, enemyPawn[randomEnemyNumber].transform.position.y, enemyPawn[randomEnemyNumber].transform.position.z);
                }
                else
                {
                    reverst = false;
                }
            }
        }
        else
        {
            if (!reverst)
            {
                if (enemyPawn[randomEnemyNumber].transform.position.z < currentPosition.z + enemyMovePoint)
                {
                    enemyPawn[randomEnemyNumber].transform.position = new Vector3(enemyPawn[randomEnemyNumber].transform.position.x, enemyPawn[randomEnemyNumber].transform.position.y, enemyPawn[randomEnemyNumber].transform.position.z + enemyMoveStep);
                }
                else
                {
                    reverst = true;
                }
            }
            else
            {
                if (enemyPawn[randomEnemyNumber].transform.position.z > currentPosition.z - enemyMovePoint)
                {
                    enemyPawn[randomEnemyNumber].transform.position = new Vector3(enemyPawn[randomEnemyNumber].transform.position.x, enemyPawn[randomEnemyNumber].transform.position.y, enemyPawn[randomEnemyNumber].transform.position.z - enemyMoveStep);
                }
                else
                {
                    reverst = false;
                }
            }
        }
    }

    public void RanddomEnemy()
    {
        int amountOfEnemy = enemyPawn.Length;
        randomEnemyNumber = Random.Range(0, amountOfEnemy);
    }
}
