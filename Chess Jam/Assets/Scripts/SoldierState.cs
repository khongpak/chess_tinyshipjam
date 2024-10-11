using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierState : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (PlayerInfo.instance.isMove && !EnemyInfo.instance.isMove)
            {
                EnemyMove.Instance.enemyPawn.Remove(other.gameObject);
                Destroy(other.gameObject);
            }
        }
    }

    
}
