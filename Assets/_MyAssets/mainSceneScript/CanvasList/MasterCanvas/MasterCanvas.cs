using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using CanvasList;
using InitialDataList;

// メインシーンにおける、画面変更を制御するクラス
public class MasterCanvas : MonoBehaviour
{
    private static CanvasList.MainScene nowCanvas = MainScene.None;
    private static IDictionary<string,Transform> childObjects = null;

    // 初期表示画面をアクティブに、他を非アクティブにする
    void Start()
    {
        // 子要素の一覧作成
        if (childObjects == null)
        {
            // 格納配列を作成
            childObjects = new Dictionary<string, Transform>();

            // 初期キャンバス
            nowCanvas = InitialDataList.initialDataList.mainSceneInitialCanvas;

            // 子要素の一覧を取得
            foreach (Transform item in transform)
            {
                // 子要素の名前を確認し、初期表示画面以外は初期化
                if(item.name.Equals(Enum.GetName(typeof(CanvasList.MainScene), InitialDataList.initialDataList.mainSceneInitialCanvas)))
                {
                    this.changeCancasActive(item.gameObject, true);
                }
                else
                {
                    this.changeCancasActive(item.gameObject, false);
                }

                // 子要素の一覧に追加
                childObjects.Add(item.name, item);
            }

        }
    }

    // アップデートはアクティブな各キャンバスで行う
    void Update()
    {
        
    }

    // 現在表示されているキャンバスを非アクティブにし、
    // 指定されたキャンバスをアクティブにする。
    void changeDisplay(CanvasList.MainScene canvasName)
    {
        Transform item = childObjects[Enum.GetName(typeof(CanvasList.MainScene), nowCanvas)];
        this.changeCancasActive(item.gameObject, false);
        item = childObjects[Enum.GetName(typeof(CanvasList.MainScene), canvasName)];
        this.changeCancasActive(item.gameObject, true);
        nowCanvas = canvasName;
    }

    // キャンパスの表示・非表示切り替え
    void changeCancasActive(GameObject item, bool change)
    {
        // 指定値で変更！
        item.SetActive(change);
        /** キャンバスグループでやろうとしたやつ
        CanvasGroup canvasGroup = item.GetComponent<CanvasGroup>();
        if (change)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
        else
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
        ***/
    }
}
