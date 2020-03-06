using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCorrectAnswerManager : MonoBehaviour
{
    public GameObject questionThree;
    public GameObject correctAnswerThreeScene;
    public GameObject wrongAnswerThreeScene1;
    public GameObject wrongAnswerThreeScene2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void correctAnswerThreePressed()
    {
        correctAnswerThreeScene.SetActive(true);
        wrongAnswerThreeScene1.SetActive(false);
        wrongAnswerThreeScene2.SetActive(false);
        questionThree.SetActive(false);
    }

    public void wrongAnswerTwo1Pressed()
    {
        wrongAnswerThreeScene1.SetActive(true);
        wrongAnswerThreeScene2.SetActive(false);
        correctAnswerThreeScene.SetActive(false);
        questionThree.SetActive(false);
    }

    public void wrongAnswerTwo2Pressed()
    {
        wrongAnswerThreeScene1.SetActive(false);
        wrongAnswerThreeScene2.SetActive(true);
        correctAnswerThreeScene.SetActive(false);
        questionThree.SetActive(false);
    }

    public void retryThreePressed()
    {
        correctAnswerThreeScene.SetActive(false);
        wrongAnswerThreeScene1.SetActive(false);
        wrongAnswerThreeScene2.SetActive(false);
        questionThree.SetActive(true);
    }

    public void continueBottonTwoPressed()
    {
        correctAnswerThreeScene.SetActive(false);
        wrongAnswerThreeScene1.SetActive(false);
        wrongAnswerThreeScene2.SetActive(false);
        questionThree.SetActive(true);
    }
}
