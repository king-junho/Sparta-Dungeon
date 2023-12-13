using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform Player { get; private set; }
    [SerializeField] private string playerTag = "Player";
    private CharacterStatsController _playerStats;

    [SerializeField] private Text IDText;
    [SerializeField] private Text descriptText;
    [SerializeField] private Text atkText;
    [SerializeField] private Text defText;
    [SerializeField] private Text hpText;
    [SerializeField] private Text criticalText;
    [SerializeField] private Slider expSlider;
    [SerializeField] private Text goldText;
    [SerializeField] private Text levelText;

    private void Awake()
    {
        instance = this;
        Player = GameObject.FindGameObjectWithTag(playerTag).transform;
    }
    private void Start()
    {
        _playerStats = Player.GetComponent<CharacterStatsController>();
        SetUI();
    }


    private void SetUI()
    {
        atkText.text = _playerStats.CurrentStats.attack.ToString();
        defText.text = _playerStats.CurrentStats.attack.ToString();
        hpText.text = _playerStats.CurrentStats.maxHealth.ToString();
        criticalText.text = _playerStats.CurrentStats.critical.ToString();
        expSlider.value = _playerStats.CurrentStats.exp;
        goldText.text = _playerStats.CurrentStats.gold.ToString();
        levelText.text = _playerStats.CurrentStats.level.ToString("00");
        IDText.text = _playerStats.CurrentStats.ID;
        descriptText.text=_playerStats.CurrentStats.descript.ToString();
    }
    private void UpdateExpUI()
    {

    }
    private void UpdateCharacterStatsUI()
    {
        
    }
}
