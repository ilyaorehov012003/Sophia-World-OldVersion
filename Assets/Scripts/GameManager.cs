using TMPro;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class GameManager : MonoBehaviour
{
    #region Variables

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI _headerLabel;
    [SerializeField] private TextMeshProUGUI _locationLabel;
    [SerializeField] private TextMeshProUGUI _descriptionLabel;
    [SerializeField] private TextMeshProUGUI _choicesLabel1;
    [SerializeField] private TextMeshProUGUI _choicesLabel2;
    [SerializeField] private TextMeshProUGUI _choicesLabel3;
    [SerializeField] private TextMeshProUGUI _choicesLabel4;
    [SerializeField] private Button _menuButton;
    [SerializeField] private Image _spriteImage;

    [Header("Initial Setup")]
    [SerializeField] private Step _startStep;

    [Header("External Components")]
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private string _menuSceneName;
    [SerializeField] private string _gameOverSceneName;
    [SerializeField] private string _gameWinSceneName;
    [SerializeField] private string _dialogScene;

    public Step _currentStep;
    private int _i;

    [SerializeField] private Image buttonprozr1;
    [SerializeField] private Image buttonprozr2;
    [SerializeField] private Image buttonprozr3;
    [SerializeField] private Image buttonprozr4;

    public GameController _currentScene;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        _menuButton.onClick.AddListener(MenuButtonClicked);
        SetCurrentStep(_startStep);
        //DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        CheckGameOver();
        CheckGameWin();
        int choiceIndex = GetPressedButtonIndex();

        if (!IsIndexValid(choiceIndex))
            return;
        SetCurrentStep(choiceIndex);
    }

    #endregion


    #region Private metods

    private bool IsIndexValid(int choiceIndex) =>
        choiceIndex >= 0;

    private int GetPressedButtonIndex()
    {
        int pressedButtonIndex = NumButtonHelper.GetPressedButtonIndex();
        return pressedButtonIndex - 1;
    }

    private void SetCurrentStep(int choiceIndex)
    {
        if (_currentStep.Choices.Length <= choiceIndex)
            return;
        Step nextStep = _currentStep.Choices[choiceIndex];
        SetCurrentStep(nextStep);
    }

    public void GoToDialog(int NumberSceneDialog)
    {
        Debug.Log("NumberSceneDialog: " + NumberSceneDialog);
        Debug.Log("NameSceneDialog: " + _currentStep.currentScene);
        _sceneLoader.LoadScene(_dialogScene);
    }

    public void SetCurrentStep(Step step)
    {
        if (step == null)
            return;

        _currentStep = step;

        if(step.GoToDialoge > 0)
        {
            GoToDialog(step.GoToDialoge);
        }

        else
        {
            SetDeleteStep(step.Choices.Length);

            _headerLabel.text = step.DebugHeaderText;
            _locationLabel.text = step.LocationText;

            if (step.LocationImage != null)
            {
                _spriteImage.color = Color.white;
                _spriteImage.sprite = step.LocationImage;
            }
            else
                _spriteImage.color = new Color(0, 0, 0, 0);

            _descriptionLabel.text = step.DescriptionText;
            _choicesLabel1.text = step.ChoicesText1;
            _choicesLabel2.text = step.ChoicesText2;
            _choicesLabel3.text = step.ChoicesText3;
            _choicesLabel4.text = step.ChoicesText4;
        }

    }

    private void SetDeleteStep(int Udal)
    {
        Debug.Log(Udal);
        if(Udal == 1)
        {
            buttonprozr1.color = new Color(255, 255, 255, 1);
            buttonprozr2.color = new Color(255, 255, 255, 0);
            buttonprozr3.color = new Color(255, 255, 255, 0);
            buttonprozr4.color = new Color(255, 255, 255, 0);
        }
        else if(Udal == 2)
        {
            buttonprozr1.color = new Color(255, 255, 255, 1);
            buttonprozr2.color = new Color(255, 255, 255, 1);
            buttonprozr3.color = new Color(255, 255, 255, 0);
            buttonprozr4.color = new Color(255, 255, 255, 0);
        }
        else if(Udal == 3)
        {
            buttonprozr1.color = new Color(255, 255, 255, 1);
            buttonprozr2.color = new Color(255, 255, 255, 1);
            buttonprozr3.color = new Color(255, 255, 255, 1);
            buttonprozr4.color = new Color(255, 255, 255, 0);
        }
        else
        {
            buttonprozr1.color = new Color(255, 255, 255, 1);
            buttonprozr2.color = new Color(255, 255, 255, 1);
            buttonprozr3.color = new Color(255, 255, 255, 1);
            buttonprozr4.color = new Color(255, 255, 255, 1);
        }
    }

    private void MenuButtonClicked()
    {
        _sceneLoader.LoadScene(_menuSceneName);
    }

    private void CheckGameOver()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            return;
        if (_currentStep.Choices.Length == 0)
        {
            _sceneLoader.LoadScene(_gameOverSceneName);
        }
    }

    private void CheckGameWin()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return;
        if (_currentStep.Choices.Length == 10)
        {
            _sceneLoader.LoadScene(_gameWinSceneName);
        }
    }

    #endregion
}