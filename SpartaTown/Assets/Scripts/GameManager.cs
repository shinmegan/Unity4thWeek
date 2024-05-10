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
        // �÷��̾� �̸��� 2�� �̻��̰� joinButton�� ��Ȱ��ȭ ������ ��
        if (playerNameInput.text.Length >= 2 && !joinButton.activeSelf)
        {
            joinButton.SetActive(true); // joinButton�� Ȱ��ȭ�մϴ�.
        }
        // �÷��̾� �̸��� 2�� �̸��̰ų� joinButton�� Ȱ��ȭ ������ ��
        else if (playerNameInput.text.Length < 2 && joinButton.activeSelf)
        {
            joinButton.SetActive(false); // joinButton�� ��Ȱ��ȭ�մϴ�.
        }
    }

    public void InputName()
    {
        //playerName = playerNameInput.text;
        //�̸� ����
        //PlayerPrefs.SetString("CurrentPlayerName", playerName);
        //��ư �̹��� Ȱ��ȭ
        
    }
}
