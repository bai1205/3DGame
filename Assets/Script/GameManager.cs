using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using XueXi;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private SceneLoader sceneLoader;
    private string SceneName;
    public List<int> useSkill = new List<int>();
    public List<int> xuanLianSkill = new List<int>();
    public void Awake()//��Ϸ��ʼ���
    {
        Instance = this;
        GameObject.DontDestroyOnLoad(this);
        WindowManager.Instance.Init();
       ConfigManager.Instance.Init();
        Save.Instance.Init();
        AudioManager.Instance.PlayAudio("Sound/��������", AudioType.bg);

        SceneManager.LoadScene("Start");
        WindowManager.Instance.OpenWindow(WindowType.StartWindow);
    }

    public void Update()
    {
    }
    internal void SceneLoad(string v)
    {
        if (SceneName!="")
        {
            SceneManager.UnloadScene(SceneName);
        }
        SceneName= v;
        SceneManager.LoadScene(v,LoadSceneMode.Additive);
    }
}