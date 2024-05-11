using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject joinImage;
    public GameObject joinButton;
    public GameObject reminder;
    public InputField playerNameInput;
    string playerName;
    public string color = "none";

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        // 플레이어 이름이 2자 이상이고 joinImage이 비활성화 상태일 때
        if (playerNameInput.text.Length >= 2 && !joinImage.activeSelf)
        {
            joinImage.SetActive(true); // joinImage 활성화
            joinButton.SetActive(true);// joinButton 활성화
            reminder.SetActive(false); // 안내문 비활성화
        }
        // 플레이어 이름이 2자 미만이거나 joinButton이 활성화 상태일 때
        else if (playerNameInput.text.Length < 2 && joinImage.activeSelf)
        {
            joinImage.SetActive(false); // joinImage 비활성화
            joinButton.SetActive(false) ;
        }
        else if (playerNameInput.text.Length == 1)
        {
            reminder.SetActive(true); //안내문 활성화
        }
        else
            reminder.SetActive(false);
    }

    public void InputName()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
    }

    public void ChosenCharacter()
    {
        PlayerPrefs.SetString("SelectedCharacterColor", color); // 선택한 캐릭터 색상을 저장
    }
}
