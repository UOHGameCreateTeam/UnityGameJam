using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

public class title_sc : MonoBehaviour
{
    void Start()
    {
        print("test");
    }

    // 中に記述された処理が一定間隔で繰り返し実行される
    void Update()
    {
        // print("cahnge");
        // もし入力したキーがSpaceキーならば、中の処理を実行する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("cahnge");
            // SampleSceneに切り替える
            SceneManager.LoadScene("stage_1");
        }
    }
}