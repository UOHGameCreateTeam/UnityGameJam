using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button_sc : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClisk()
    {

        print("cahnge");
        Debug.Log("�{�^����������܂����I");
            // SampleScene�ɐ؂�ւ���
        SceneManager.LoadScene("select_scene");
      
    }
}
