using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text nameTxt;
    string playername;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("CurrentPlayerName"))
        {
            playername = PlayerPrefs.GetString("CurrentPlayerName");
            ApplyName(playername);
        }
    }

    void ApplyName(string name)
    {
        nameTxt.text = name;
    }
}
