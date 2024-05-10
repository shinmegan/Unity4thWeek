using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject joinButton;
    public InputField playerNameInput;

    private void Awake()
    {
        if(instance == null)
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
        // 플레이어 이름이 2자 이상이고 joinButton이 비활성화 상태일 때
        if (playerNameInput.text.Length >= 2 && !joinButton.activeSelf)
        {
            joinButton.SetActive(true); // joinButton을 활성화합니다.
        }
        // 플레이어 이름이 2자 미만이거나 joinButton이 활성화 상태일 때
        else if (playerNameInput.text.Length < 2 && joinButton.activeSelf)
        {
            joinButton.SetActive(false); // joinButton을 비활성화합니다.
        }
    }

    public void InputName()
    {
        //playerName = playerNameInput.text;
        //이름 저장
        //PlayerPrefs.SetString("CurrentPlayerName", playerName);
        //버튼 이미지 활성화
        
    }
}
