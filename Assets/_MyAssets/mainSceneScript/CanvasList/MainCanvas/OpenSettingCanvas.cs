using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettingCanvas : MonoBehaviour
{
    // 画面切り替え用
    private GameObject _parent = null;

    // 設定画面移動メソッド
    private string settingCanvasChangeMethod = "changeSettingCanvas";

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
        
    }

    public void OnClick()
    {
        this._parent.SendMessage(settingCanvasChangeMethod);
    }
}
