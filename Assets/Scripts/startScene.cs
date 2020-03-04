using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public Animation anim;

    public GameObject nameOrder;
    public GameObject startButton;
    public GameObject registerDia;
    public GameObject nameDia;
    public GameObject student;
    public GameObject staff;

    public bool startScenePressed;

    public GameObject oneToTwoButton;
    public GameObject twoToThreeButton;
    public GameObject threeToFourButton;
    public GameObject fourToFiveButton;
    public GameObject fiveToSixButton;

    public GameObject questionOne;
    public GameObject questionTwo;
    public GameObject correctAnswerOneScene;

    // Start is called before the first frame update
    void Start()
    {
        startButton.SetActive(true);
        staff.SetActive(false);
        oneToTwoButton.SetActive(false);
        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(false);
        nameOrder.SetActive(false);
        registerDia.SetActive(false);
        nameDia.SetActive(false);
        fourToFiveButton.SetActive(false);
        fiveToSixButton.SetActive(false);
        questionOne.SetActive(false);
        questionTwo.SetActive(false);
        correctAnswerOneScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(startScenePressed == true)
        {
            SceneStarted();
            
        }
    }

    public void StartPressed()
    {
        anim.Play();
        anim.CrossFade("walk_00");

        oneToTwoButton.SetActive(true);
        twoToThreeButton.SetActive(false);
        threeToFourButton.SetActive(false);
        startButton.SetActive(false);
        registerDia.SetActive(false);
        nameDia.SetActive(false);

        startScenePressed = true;
    }

    public void SceneStarted()
    {
        anim = student.GetComponent<Animation>();

        if (student.transform.position.x < -4027)
        {
            student.transform.position += student.transform.forward * Time.deltaTime * moveSpeed;
        }
        else
        {
            Debug.Log(student.transform.position);
            //anim.Stop();
            startScenePressed = false;
        }

    }


}
