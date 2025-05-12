using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public string mainWord = "defult";
    public int livesCount = 10;
    public TextMeshProUGUI mainWordText;
    public TextMeshProUGUI LivesCountText;
    public TextMeshProUGUI messageText;
    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
        LivesCountText.text = $"Zostało {livesCount} prób";
    }

    public void OnClick()
    {
        Debug.Log($"Guzik został kliknienty");
        //livesCount = livesCount - 1;
        livesCount--;
        LivesCountText.text = $"Zostało {livesCount} prób";

        if (mainWord == inputField.text) ;
        {
            messageText.text = $"poprawne słowo zostało wpisane";
            return; //koniec metody
        }
        if (mainWord.Length != inputField.text.Length) 
        {
            messageText.text = $"liczba liter się nie zgadza";
            return; //koniec metody
        }

        int bullsCount = CountBulls();
        int cowsCount = CountCows();
        messageText.text = $"Bulls: {bullsCount} and Cows: {cowsCount}";
    }

    public int  CountBulls()
    {
        int result = 0;

        for (int i = 0; i < mainWord.Length; i++) 
        {
            if (mainWord[i] == inputField.text[i])
            {
                result++;
            }


        return result;

    }
     public int CountCows()
     {

        int result = 0;
        for (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] == inputField.text[i] && mainWord.Contains(inputField.text[i]) )
            {
              result++;

            }
        }
      }
        // Update is called once per frame
        void Update()
    {
        
    }
}
