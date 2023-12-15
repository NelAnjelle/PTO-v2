using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TextMeshProUGUI QuestionTxt;

    public GameObject QuizPanel;
    public GameObject GoPanel;
    public TextMeshProUGUI ScoreTxt;
    private int totalQuestions = 0;
    public int score;

    public TextMeshProUGUI gradeTxt;
    public string grade;

    [SerializeField] private AudioSource correctSoundEffect;
    [SerializeField] private AudioSource wrongSoundEffect;


    public TextMeshProUGUI HighScoreTxt;
    

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);

        HighScoreTxt.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();

        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        QuizPanel.SetActive(false);
        GoPanel.SetActive(true);
        double percentage = (score / (double)totalQuestions) * 100;

        if(percentage == 100)
        {
            grade = "Perfect";
        }else if(percentage >= 75 && percentage < 100)
        {
            grade = "Good";
        }else if(percentage >= 50 && percentage < 75)
        {
            grade = "Not bad";
        }else{
            grade = "Bad";
        }

        
        ScoreTxt.text = score + " / " + totalQuestions;
        gradeTxt.text = grade;
        SetHighscore();
        
    }

    public void correct()
    {
        score +=1;
        correctSoundEffect.Play();
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        wrongSoundEffect.Play();
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for(int i=0; i<options.Length; i++)
        {
            
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            // options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i]; 

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
                
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
        currentQuestion = Random.Range(0,QnA.Count);

        QuestionTxt.text = QnA[currentQuestion].Question;
        SetAnswers();
        }else
        {
            Debug.Log("We are out of questions.");
            GameOver();
        }

        
    }

    void SetHighscore()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName;
        currentSceneName = currentScene.name;

        if(currentSceneName == "Life Assessment")
        {
            if (score > PlayerPrefs.GetInt("HighScoreForLife", 0))
        {
            PlayerPrefs.SetInt("HighScoreForLife", score);
            PlayerPrefs.Save();
        }

        // Retrieve the high score from PlayerPrefs and display it
        int highScoreForLife = PlayerPrefs.GetInt("HighScoreForLife", 0);
        HighScoreTxt.text = "High Score: " + highScoreForLife.ToString();
        
        }else if(currentSceneName == "Work Assessment")
        {
            if (score > PlayerPrefs.GetInt("HighScoreForWork", 0))
        {
            PlayerPrefs.SetInt("HighScoreForWork", score);
            PlayerPrefs.Save();
        }

        int highScoreForWork = PlayerPrefs.GetInt("HighScoreForWork", 0);
        HighScoreTxt.text = "High Score: " + highScoreForWork.ToString();
        
        }else if(currentSceneName == "Philosophy Assessment")
        {
            if (score > PlayerPrefs.GetInt("HighScoreForPhilosophy", 0))
        {
            PlayerPrefs.SetInt("HighScoreForPhilosophy", score);
            PlayerPrefs.Save();
        }

        int highScoreForPhilosophy = PlayerPrefs.GetInt("HighScoreForPhilosophy", 0);
        HighScoreTxt.text = "High Score: " + highScoreForPhilosophy.ToString();
        
        }

    }

}
