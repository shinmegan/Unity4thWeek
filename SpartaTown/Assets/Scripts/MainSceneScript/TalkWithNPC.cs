using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkWithNPC : MonoBehaviour
{
    public Transform player;
    public Transform npc;
    public float popUpDistance = 6f; //팝업이 나타날 거리
    public GameObject talkPopUp;
    public GameObject bellBtn;
    public GameObject npcGameObject;
    public GameObject dialogueImage;
    public bool isStartTalk = false; //npc가 대화를 시작했는지 확인

    // Update is called once per frame
    void Update()
    {
        //플레이어와 NPC 사이의 거리 계산(magnitude)
        float distance = (player.position - npc.position).magnitude;

        //일정 거리로 가까워지면 팝업 창 표시
        if (distance <= popUpDistance && !isStartTalk)
        {
            OpenPopUp();
        }
        else if (distance > popUpDistance || isStartTalk)
        {
            ClosePopUp();
        }
    }
    //대화걸기 버튼 활성화
    void OpenPopUp()
    {
        talkPopUp.SetActive(true);
        bellBtn.SetActive(true);
    }
    //대화걸기 버튼 비활성화
    void ClosePopUp()
    {
        talkPopUp.SetActive(false);
        bellBtn.SetActive(false);
    }

    public void StartConversation()
    {
        isStartTalk = true;
        //DialogueImage UI 활성화
        dialogueImage.SetActive(true);

        if (npcGameObject != null)
        {
            //NPC 오브젝트에서 DialogueDataLoader 스크립트를 찾음
            DialogueDataLoader dataLoader = npcGameObject.GetComponent<DialogueDataLoader>();

            //대화 시스템이 존재하면 실행
            if (dataLoader != null)
            {
                dataLoader.LoadDialogueData();
            }
            else
                Debug.LogWarning("DialogueSystem script not found.");
        }
    }

    public void StopConversaion()
    {
        dialogueImage.SetActive(false);
        isStartTalk = false ;
    }
}
