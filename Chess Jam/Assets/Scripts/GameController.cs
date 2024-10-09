using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public static GameController instance;

    
    public TMP_InputField commandInputText;
    public float enemyThinkingTime;
    public Button turnButton;
    public List<PlayerInfo> pawn = new List<PlayerInfo>();

    private int turnCount = 0;
    [SerializeField] private TextMeshProUGUI turnText;


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
        turnCount++;
        turnText.text = "Turn : " + turnCount;
        turnButton.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(enemyThinkingTime);
        EnemyMove.Instance.Move();
        turnButton.gameObject.SetActive(true);
        commandInputText.text = "";
        Debug.Log("Player Turn");

    }
}
