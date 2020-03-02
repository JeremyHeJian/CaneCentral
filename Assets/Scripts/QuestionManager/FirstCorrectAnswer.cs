using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCorrectAnswer : MonoBehaviour
{
    public GameObject questionOne;
    public GameObject questionTwo;
    public GameObject correctAnswerOneScene;
    public GameObject wrongAnswerScene1;
    public GameObject wrongAnswerScene2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void correctAnswerOnePressed()
    {
        questionOne.SetActive(false);
        correctAnswerOneScene.SetActive(true);
        wrongAnswerScene1.SetActive(false);
        wrongAnswerScene2.SetActive(false);
    }

    public void wrongAnswer1Pressed()
    {
        questionOne.SetActive(false);
        wrongAnswerScene1.SetActive(true);
        wrongAnswerScene2.SetActive(false);
        correctAnswerOneScene.SetActive(false);
    }

    public void wrongAnswer2Pressed()
    {
        questionOne.SetActive(false);
        wrongAnswerScene1.SetActive(false);
        wrongAnswerScene2.SetActive(true);
        correctAnswerOneScene.SetActive(false);
    }

    public void retryPressed()
    {
        questionOne.SetActive(true);
        correctAnswerOneScene.SetActive(false);
        wrongAnswerScene1.SetActive(false);
        wrongAnswerScene2.SetActive(false);
    }

    public void continueBottonPressed()
    {
        questionTwo.SetActive(true);
        questionOne.SetActive(false);
        correctAnswerOneScene.SetActive(false);
        wrongAnswerScene1.SetActive(false);
        wrongAnswerScene2.SetActive(false);

    }
}
