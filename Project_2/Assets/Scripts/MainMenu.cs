using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject easy;
    [SerializeField]
    private GameObject medium;
    [SerializeField]
    private GameObject hiragana;


    public static int GameModeSelected;

    private void Start()
    {
        GameModeSelected = 0;
    }


    public void PlayGame()
    {
        if (hiragana.GetComponent<Toggle>().isOn)
        {
            if (easy.GetComponent<Toggle>().isOn)
            {
                GameModeSelected = 1;
            }
            else if (medium.GetComponent<Toggle>().isOn)
            {
                GameModeSelected = 2;
            }
            else
            {
                GameModeSelected = 3;
            }
        }
        else
        {
            if (easy.GetComponent<Toggle>().isOn)
            {
                GameModeSelected = 4;
            }
            else if (medium.GetComponent<Toggle>().isOn)
            {
                GameModeSelected = 5;
            }
            else
            {
                GameModeSelected = 6;
            }
        }

        SceneManager.LoadScene(GameModeSelected);
    
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
