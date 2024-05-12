using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager instance;
    public GameObject changeName;
    public GameObject playerNameInput;
    public GameObject checkImage;
    public GameObject checkBtn;
    public GameObject withdrawBtn;
    public GameObject attendImage;
    public GameObject attendTitle;
    public GameObject xBtn;
    public GameObject letterReminder;
    public InputField NameInput;
    string changedName;
    //PopUpImage 프리팹을 인스턴스화할 변수
    public GameObject popUpPrefab;
    public GameObject characterBtn;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        if (NameInput != null && NameInput.text.Length == 1) //한 글자만 입력했으면,
            letterReminder.SetActive(true); //안내문 활성화
        else
            letterReminder.SetActive(false);
        //플레이어 이름이 2자 이상이면
        if (NameInput != null && NameInput.text.Length >= 2)
        {
            checkImage.SetActive(true);
            checkBtn.SetActive(true);
        }
        else
        {
            checkImage.SetActive(false);
            checkBtn.SetActive(false);
        }
    }
    //변경된 이름 저장 메서드
    public void SaveChangedName()
    {
        changedName = NameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", changedName);
        CloseName();
        NameInput.text = ""; //InputField 초기화
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
    public void CloseName()
    {
        changeName.SetActive(false);
        checkImage.SetActive(false);
        checkBtn.SetActive(false);
        playerNameInput.SetActive(false);
        withdrawBtn.SetActive(false);
        letterReminder.SetActive(false);
        UIManager.instance.allowMovement = true;
        NameInput.text = ""; //InputField 초기화
    }

    //참석자명단 띄우는 메서드
    public void AttendImagePopUp()
    {
        attendImage.SetActive(true);
        attendTitle.SetActive(true);
        xBtn.SetActive(true);
    }

    //참석자명단 닫는 메서드
    public void CloseAttend()
    {
        attendImage.SetActive(false);
        attendTitle.SetActive(false);
        xBtn.SetActive(false);
    }

    //캐릭터 선택창 띄우는 메서드
    public void OpenPopUp()
    {
        // 프리팹을 현재 위치와 회전으로 인스턴스화
        Instantiate(popUpPrefab, transform.position, transform.rotation);
    }
}
