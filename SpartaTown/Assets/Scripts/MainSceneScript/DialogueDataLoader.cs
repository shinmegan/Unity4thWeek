using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDataLoader : MonoBehaviour
{
    //대화 내용 표시할 UI
    public Text dialogueTxt;
    //대화 데이터 파일 경로
    public string dialogueFilePath = "Assets/Dialogues/DialogueData.txt";

    void Start()
    {
        LoadDialogueData();
    }

    public void LoadDialogueData()
    {
        if (File.Exists(dialogueFilePath))
        {
            string[] lines = File.ReadAllLines(dialogueFilePath);
            foreach (string line in lines)
            {
                //대화 데이터를 읽어와 UI 텍스트 요소에 출력
                dialogueTxt.text += line + "\n";
            }
        }
        else
            Debug.LogError("Dialogue file does't exist");
    }
   
}
