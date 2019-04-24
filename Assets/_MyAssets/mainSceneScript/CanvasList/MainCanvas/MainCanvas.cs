using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{

    // 画面切り替え用
    private GameObject _parent = null;

    // メイン画面
    private string mainCanvasChangeMethod = "changeDisplay";

    // Start is called before the first frame update
    void Start()
    {
        //親オブジェクトを取得
        if (_parent == null)
        {
            _parent = transform.root.gameObject;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        // 必要な情報の保存後、設定画面へ遷移する
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.changeSettingCanvas();
        }
    }

    // 設定画面への移動
    void changeSettingCanvas()
    {
        this.SaveCanvasSetting();
        this._parent.SendMessage(mainCanvasChangeMethod, CanvasList.MainScene.Setting);
    }

    void SaveCanvasSetting()
    {
        // 設定保存
    }

    void LoadCavasSetting()
    {
        // 設定読み込み（表示用）
    }
}
