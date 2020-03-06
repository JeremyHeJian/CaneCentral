using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCorrectAnswerManager : MonoBehaviour
{
    public GameObject questionTwo;
    public GameObject questionThree;
    public GameObject correctAnswerTwoScene;
    public GameObject wrongAnswerTwoScene1;
    public GameObject wrongAnswerTwoScene2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void correctAnswerTwoPressed()
    {
        correctAnswerTwoScene.SetActive(true);
        wrongAnswerTwoScene1.SetActive(false);
        wrongAnswerTwoScene2.SetActive(false);
        questionTwo.SetActive(false);
    }

    public void wrongAnswerTwo1Pressed()
    {
        wrongAnswerTwoScene1.SetActive(true);
        wrongAnswerTwoScene2.SetActive(false);
        correctAnswerTwoScene.SetActive(false);
        questionTwo.SetActive(false);
    }

    public void wrongAnswerTwo2Pressed()
    {
        wrongAnswerTwoScene1.SetActive(false);
        wrongAnswerTwoScene2.SetActive(true);
        correctAnswerTwoScene.SetActive(false);
        questionTwo.SetActive(false);
    }

    public void retryTwoPressed()
    {
        correctAnswerTwoScene.SetActive(false);
        wrongAnswerTwoScene1.SetActive(false);
        wrongAnswerTwoScene2.SetActive(false);
        questionTwo.SetActive(true);
    }

    public void continueBottonTwoPressed()
    {
        correctAnswerTwoScene.SetActive(false);
        wrongAnswerTwoScene1.SetActive(false);
        wrongAnswerTwoScene2.SetActive(false);
        questionThree.SetActive(true);
    }
}
