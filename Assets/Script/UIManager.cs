using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text _timerText = null;
    private Text timerText { get { return _timerText; } }
    public static UIManager instance { get; set; } = null;

    public Text _goldText = null;
    private Text goldText { get { return _timerText; } }

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        
    }
    public void SetTimer(float timer)
    {
        timerText.text = "Timer:" + timer.ToString("F1");
    }

    public void SetGold(int gold)
    {
        goldText.text = "Gold:" + gold.ToString("F1");
    }
}
