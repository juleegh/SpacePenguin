using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button exitPauseButton;
    [SerializeField] private GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(OnPauseButtonClicked);
        exitPauseButton.onClick.AddListener(OnExitPauseButtonClicked);
    }

    private void OnPauseButtonClicked()
    {
        pauseMenu.SetActive(true);
    }

    private void OnExitPauseButtonClicked()
    {
        pauseMenu.SetActive(false);
    }
}
