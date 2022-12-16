using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_board : MonoBehaviour
{
    public TMP_Text score_text;
    public float score = 0;
    private bool vs_result;
    // Start is called before the first frame update
    void Start()
    {
        string show_text;

        show_text = string.Format("{0}", score);
        score_text.text = show_text;

    }

    // Update is called once per frame
    void Update()
    {
        string show_text;
        show_text = score.ToString();
        score_text.text = show_text;
    }

}
