using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombinationLockManager : MonoBehaviour
{
    [SerializeField] Text KeyText_0;    //Button_0のテキスト
    [SerializeField] Text KeyText_1;    //Button_1のテキスト
    [SerializeField] Text KeyText_2;    //Button_2のテキスト
    [SerializeField] Animator CombinationLockAnim;  //解錠のアニメーション
    [SerializeField] Button Button_0;
    [SerializeField] Button Button_1;
    [SerializeField] Button Button_2;

    public void OnClickButton_0()
    {
        Debug.Log("ClickButton0");
        ChangeNumber_0();
        CheckPassword();
    }

    public void OnClickButton_1()
    {
        Debug.Log("ClickButton1");
        ChangeNumber_1();
        CheckPassword();
    }

    public void OnClickButton_2()
    {
        Debug.Log("ClickButton2");
        ChangeNumber_2();
        CheckPassword();
    }




    int NumberOfClickButton_0 = 0;
    void ChangeNumber_0()
    {
        NumberOfClickButton_0 = (NumberOfClickButton_0 + 1) % 10;   //１桁のみ表示させる
        KeyText_0.text = NumberOfClickButton_0.ToString();
    }

    int NumberOfClickButton_1 = 0;
    void ChangeNumber_1()
    {
        NumberOfClickButton_1 = (NumberOfClickButton_1 + 1) % 10;   //１桁のみ表示させる
        KeyText_1.text = NumberOfClickButton_1.ToString();
    }

    int NumberOfClickButton_2 = 0;
    void ChangeNumber_2()
    {
        NumberOfClickButton_2 = (NumberOfClickButton_2 + 1) % 10;   //１桁のみ表示させる
        KeyText_2.text = NumberOfClickButton_2.ToString();
    }




    void CheckPassword()    //正誤判定
    {
        //CorrectPassword
        if(KeyText_0.text == "3" && KeyText_1.text == "8" && KeyText_2.text == "4")
        {
            Debug.Log("Correct");


            Button_0.interactable = false;    //ボタンの入力受付禁止
            Button_1.interactable = false;
            Button_2.interactable = false;

            CombinationLockAnim.SetTrigger("Unlock_Trigger");   //Animator ControllerのUnlockTriggerをセットする

        }
    }

}
