using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

public class title_sc : MonoBehaviour
{
    void Start()
    {
        print("test");
    }

    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
    void Update()
    {
        // print("cahnge");
        // �������͂����L�[��Space�L�[�Ȃ�΁A���̏��������s����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("cahnge");
            // SampleScene�ɐ؂�ւ���
            SceneManager.LoadScene("stage_1");
        }
    }
}