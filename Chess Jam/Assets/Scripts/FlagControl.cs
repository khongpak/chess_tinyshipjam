using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.name.ToLower() == "king")
        {
            Debug.Log("Finish");
        }
    }
}
