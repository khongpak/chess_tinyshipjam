using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;
    public string pawnName;
    public TextMeshPro nameText;
    public bool isMove;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
        nameText.text = pawnName;
        gameObject.name = pawnName;
    }

    
   
}
