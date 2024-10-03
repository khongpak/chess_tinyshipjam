using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Runtime.CompilerServices;

public class ChessMoveControl : MonoBehaviour
{
    public GameObject kingPawn;
    public TMP_InputField commandInputText;

    private float gabBetweenTable = 1.32f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Endturn()
    {
        PawnMove(kingPawn);
    }

    public void PawnMove(GameObject pawnName)
    {
        float moveX = pawnName.transform.position.x;
        float moveY = pawnName.transform.position.y;
        float moveZ = pawnName.transform.position.z;

        if (commandInputText.text == "go")
        {
            moveX = pawnName.transform.position.x;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z + gabBetweenTable;

        }

        if (commandInputText.text == "down")
        {
            moveX = pawnName.transform.position.x;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z - gabBetweenTable;
        }

        if (commandInputText.text == "left")
        {
            moveX = pawnName.transform.position.x - gabBetweenTable;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z;
        }

        if (commandInputText.text == "right")
        {
            moveX = pawnName.transform.position.x + gabBetweenTable;
            moveY = pawnName.transform.position.y;
            moveZ = pawnName.transform.position.z;
        }

        pawnName.transform.position = new Vector3(moveX, moveY, moveZ);
    }
}
