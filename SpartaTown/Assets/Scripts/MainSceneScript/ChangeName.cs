using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public GameObject checkImage;
    public GameObject checkBtn;
    public GameObject letterReminder;
    public InputField playerNameInput;
    string changedName;

    // Update is called once per frame
    void Update()
    {
        // 플레이어 이름이 2자 이상이고 checkImage가 비활성화 상태일 때
        if (playerNameInput != null && playerNameInput.text.Length >= 2 && !checkImage.activeSelf)
        {
            checkImage.SetActive(true); // checkImage 활성화
            checkBtn.SetActive(true);// checkBtn 활성화
            letterReminder.SetActive(false); // 안내문 비활성화
        }
        // 플레이어 이름이 2자 미만이거나 checkImage가 활성화 상태일 때
        else if (playerNameInput != null && playerNameInput.text.Length < 2 && checkImage.activeSelf)
        {
            checkImage.SetActive(false); // checkImage 비활성화
            checkBtn.SetActive(false);
        }
        else if (playerNameInput != null && playerNameInput.text.Length == 1)
        {
            letterReminder.SetActive(true); //안내문 활성화
        }
        else
            letterReminder.SetActive(false);
    }

    public void SaveChangedName()
    {
        changedName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", changedName);
        PopUpManager.instance.ClosePopUp();
        checkImage.SetActive(false);
        checkBtn.SetActive(false);
        playerNameInput.text = ""; //InputField 초기화
    }
}
