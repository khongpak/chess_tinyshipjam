using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Runtime.CompilerServices;


public class ChessMoveControl : MonoBehaviour
{
    public static ChessMoveControl instance;

    private float gabBetweenTable = 1.32f;
    private string pawnName,pawnMove;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void PawnMoveOrder(GameObject pawnName)
    {
        float moveX = pawnName.transform.position.x;
        float moveY = pawnName.transform.position.y;
        float moveZ = pawnName.transform.position.z;

        if (pawnMove == "up")
        {
            moveX = pawnName.transform.position.x;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z + gabBetweenTable;

        }

        if (pawnMove == "down")
        {
            moveX = pawnName.transform.position.x;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z - gabBetweenTable;
        }

        if (pawnMove == "left")
        {
            moveX = pawnName.transform.position.x - gabBetweenTable;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z;
        }

        if (pawnMove == "right")
        {
            moveX = pawnName.transform.position.x + gabBetweenTable;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z;
        }

        pawnName.transform.position = new Vector3(moveX, moveY, moveZ);
    }

    public void PawnMove()
    {
        string command = GameController.instance.commandInputText.text.ToLower();
        RegularExpression.instance.MyRegex(command);
        pawnName = RegularExpression.instance.Get_RexOrder("name");
        pawnMove = RegularExpression.instance.Get_RexOrder("move");

        if (pawnName == "king")
        {
            PawnMoveOrder(GameController.instance.kingPawn);
        }
        else if (pawnName == "s1")
        {
            PawnMoveOrder(GameController.instance.soldierPawn);
        }
    }
}
