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

        savePath = Path.Combine(Application.persistentDataPath, "SaveUserData.json");    //���� ���� ��ġ �� �̸� ����
        LoadUserData();
    }

    public void SaveUserData()      //�����͸� json���� �ٲ㼭 ������ ��ġ�� �̸����� �����ϱ�
    {
        string json = JsonUtility.ToJson(userData, true);
        File.WriteAllText(savePath, json);
        Debug.Log($"���� {savePath}");
    }

    public void LoadUserData()      //����� ������ ������ȭ �ؼ� �����Ϳ� �ʱ�ȭ ���� ������ ���ٸ� ���ο� ���� ���� �� ����
    {

        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            userData = JsonUtility.FromJson<UserData>(json);
            Debug.Log($"�ε� {savePath}");
        }
        else
        {
            userData = new UserData("�����", 85000, 115000);
            SaveUserData();
        }

    }
}


