using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }

    

}
