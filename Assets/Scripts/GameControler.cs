using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public string mainWord = "defult";
    public TextMeshProUGUI mainWordText;

    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
