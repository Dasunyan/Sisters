using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using InitialDataList;
using SceneList;

public class SendInitial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InitialDataList.initialDataList.InitialDataLists();
        Invoke("changeTitleScene", InitialDataList.initialDataList.LogoDisplayTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeTitleScene()
    {
        SceneManager.LoadScene(Enum.GetName(typeof(SceneList.Scenes), SceneList.Scenes.Title));
    }
}
