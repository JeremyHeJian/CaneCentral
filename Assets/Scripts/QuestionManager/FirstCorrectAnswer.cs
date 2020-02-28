using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCorrectAnswer : MonoBehaviour
{
    public GameObject questionOne;
    public GameObject questionTwo;
    public GameObject correctAnswerOneScene;
    public GameObject wrongAnswerScene;
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
    }

    public void wrongAnswerPressed()
    {
        questionOne.SetActive(false);
        wrongAnswerScene.SetActive(true);

    }

    public void continueBottonPressed()
    {
        questionTwo.SetActive(true);

    }
}
