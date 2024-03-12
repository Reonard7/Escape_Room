using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Menu Buttons")]
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueGameButton;

    [SerializeField] public string sceneName;
    public GameObject canvasMenu;
    public GameObject canvasCredits;
    


    private void Start()
    {
        if (!DataPersistenceManager.instance.HasGameData())
        {
            continueGameButton.interactable = false;
        }
    }
    public void OnNewGameClicked()
    {
        DataPersistenceManager.instance.NewGame();
        SceneManager.LoadSceneAsync(sceneName);
    }
    public void OnContinueGameClicked()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void OnCreditsClicked()
    {
        canvasMenu.SetActive(false);
        canvasCredits.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            canvasMenu.SetActive(true);
            canvasCredits.SetActive(false);
        }
    }
}
