using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            // 현재 인스턴스가 없으면 새로운 인스턴스로 설정하고, DontDestroyOnLoad로 설정
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 이미 인스턴스가 있으면 이 GameObject를 파괴하여 중복 방지
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // 배경 음악 재생 코드
        GetComponent<AudioSource>().Play();
    }
}
