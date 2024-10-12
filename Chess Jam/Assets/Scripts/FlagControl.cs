using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.name.ToLower() == "king")
        {
            Destroy(gameObject);
            GameController.instance.gamestatus.text = "You Win!";
            GameController.instance.gamestatus.color = Color.blue;
            GameController.instance.buttonNextText.text = "NextLevel";
            GameController.instance.finishPanel.SetActive(true);
        }
    }
}
