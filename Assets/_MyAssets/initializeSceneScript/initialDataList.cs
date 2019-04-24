using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CanvasList;

// 初期化用データ一覧
namespace InitialDataList
{
    class initialDataList{
        /************************
         * 初期化用変数リスト
         ************************/

        // ロゴ（企業名）を表示する時間数
        public static int LogoDisplayTime = 0;

        // タイトルのみを表示する時間数
        public static int TitleDisplayTime = 0;

        // メインシーンでの最初に表示する画面
        public static CanvasList.MainScene mainSceneInitialCanvas = MainScene.None;


        /************************
         * 初期化用変数の初期化処理
         ************************/
        public static void InitialDataLists()
        {
            LogoDisplayTime = 3;
            TitleDisplayTime = 10;
            mainSceneInitialCanvas = MainScene.Main;
        }

    }
}