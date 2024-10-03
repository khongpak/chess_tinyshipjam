using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
public class RegularExpression : MonoBehaviour
{
    public static RegularExpression instance;

    private string pawnName;
    private string pawnMove;


    private void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        MyRegex("King,down");
    }


    void Update()
    {
        
    }

    public void MyRegex(string orderCommand)
    {
        string text = orderCommand;
        string pattern1 = @"^\w+";
        string pattern2 = @"\w+$";

        Regex regex1 = new Regex(pattern1);
        Regex regex2 = new Regex(pattern2);
        Match match1 = regex1.Match(text);
        Match match2 = regex2.Match(text);

        pawnName = match1.Value;
        pawnMove = match2.Value;

        Debug.Log("First :" + pawnName);
        Debug.Log("Second :" + pawnMove);
    }

    public string Get_RexOrder(string order)
    {
        if (order == "name")
        {
            return pawnName;
        }
        else if (order == "move")
        {
            return pawnMove;
        }
        else
        {
            return "0";
        }
    }
}
