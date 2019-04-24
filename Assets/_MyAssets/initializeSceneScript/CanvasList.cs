using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasList
{
    // シーン及び画面のリストは
    // テキストメモを参照
    // シーン名に紐づけてenumを作成する
    // 各enum無いのキャンバス名はオブジェクトと対応させる

    enum InitializeScene
    {
        None,
        Logo
    }

    enum MainScene
    {
        None,
        Main,
        MagicCreate,
        Setting
    }
}
