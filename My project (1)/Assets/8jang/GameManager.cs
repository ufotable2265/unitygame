using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject GmaeOverText;
    public TMPro.TextMeshProUGUI timeText;
    public TMPro.TextMeshProUGUI recodeText;

    float surviveTime;
    bool isGameOver;
    
    
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime += Time.deltaTime;

            timeText.text = "Time" + (int)surviveTime;



        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene("8jang");

            }

        }


    }

    public void Endgame()
    {
        isGameOver = true;
        GmaeOverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;

            PlayerPrefs.SetFloat("BestTime", bestTime);



        }
        recodeText.text = "Best Time" + (int)bestTime;





    }












}
