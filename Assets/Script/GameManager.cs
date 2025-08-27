using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public UserData userData;

    private string savePath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        savePath = Path.Combine(Application.persistentDataPath, "SaveUserData.json");    //파일 저장 위치 및 이름 설정
        LoadUserData();
    }

    public void SaveUserData()      //데이터를 json언어로 바꿔서 지정한 위치에 이름으로 저장하기
    {
        string json = JsonUtility.ToJson(userData, true);
        File.WriteAllText(savePath, json);
        Debug.Log($"저장 {savePath}");
    }

    public void LoadUserData()      //저장된 파일을 역직렬화 해서 데이터에 초기화 만약 파일이 없다면 새로운 정보 생성 및 저장
    {

        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            userData = JsonUtility.FromJson<UserData>(json);
            Debug.Log($"로드 {savePath}");
        }
        else
        {
            userData = new UserData("김재경", 85000, 115000);
            SaveUserData();
        }

    }
}


