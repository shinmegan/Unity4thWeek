using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager instance;
    public GameObject changeName;
    public GameObject playerNameInput;
    public GameObject withdrawBtn;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //이름변경창 띄우는 메서드
    public void ChangeNamePopUp()
    {
        changeName.SetActive(true);
        playerNameInput.SetActive(true);
        withdrawBtn.SetActive(true);
        UIManager.instance.allowMovement = false;
    }

    //이름변경창 닫는 메서드
    public void ClosePopUp()
    {
        changeName.SetActive(false);
        playerNameInput.SetActive(false);
        withdrawBtn.SetActive(false);
        UIManager.instance.allowMovement = true;
    }
}
