using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject kingPawn, soldierPawn;
    public TMP_InputField commandInputText;
    public float enemyThinkingTime;
    public Button turnButton;

    public List<PlayerInfo> pawn = new List<PlayerInfo>();


    private void Awake()
    {
        instance = this;
    }

    public void Endturn()
    {
        StartCoroutine(WaitTurn()); 
    }

    private IEnumerator WaitTurn()
    {
        ChessMoveControl.instance.PawnMove();
        turnButton.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(enemyThinkingTime);
        EnemyMove.Instance.Move();
        turnButton.gameObject.SetActive(true);
        commandInputText.text = "";
        Debug.Log("Player Turn");

    }
}
