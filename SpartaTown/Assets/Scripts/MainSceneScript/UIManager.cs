using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text nameTxt;
    public GameObject blueBox;
    public GameObject pinkBox;
    string playername;
    string selectedCharacter;

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
        if (PlayerPrefs.HasKey("SelectedCharacterColor"))
        {
            selectedCharacter = PlayerPrefs.GetString("SelectedCharacterColor");
            ChangeCharacter(selectedCharacter);
        }
    }

    //선택된 이름 적용 메서드
    void ApplyName(string name)
    {
        nameTxt.text = name;
    }

    //선택된 캐릭터로 변경 메서드
    void ChangeCharacter(string color)
    {
        if (color == "blue")
        {
            blueBox.SetActive(true);
            pinkBox.SetActive(false);
        }
        else if (color == "pink")
        {
            blueBox.SetActive(false);
            pinkBox.SetActive(true);
        }
    }
}