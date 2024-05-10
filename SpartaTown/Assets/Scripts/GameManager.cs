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
        // �÷��̾� �̸��� 2�� �̻��̰� joinImage�� ��Ȱ��ȭ ������ ��
        if (playerNameInput.text.Length >= 2 && !joinImage.activeSelf)
        {
            joinImage.SetActive(true); // joinImage Ȱ��ȭ
            joinButton.SetActive(true);// joinButton Ȱ��ȭ
            reminder.SetActive(false); // �ȳ��� ��Ȱ��ȭ
        }
        // �÷��̾� �̸��� 2�� �̸��̰ų� joinButton�� Ȱ��ȭ ������ ��
        else if (playerNameInput.text.Length < 2 && joinImage.activeSelf)
        {
            joinImage.SetActive(false); // joinImage ��Ȱ��ȭ
            joinButton.SetActive(false) ;
        }
        else if (playerNameInput.text.Length == 1)
        {
            reminder.SetActive(true); //�ȳ��� Ȱ��ȭ
        }
        else
            reminder.SetActive(false);
    }

    public void InputName()
    {
        //playerName = playerNameInput.text;
        //�̸� ����
        //PlayerPrefs.SetString("CurrentPlayerName", playerName);
        //��ư �̹��� Ȱ��ȭ
    }
}
