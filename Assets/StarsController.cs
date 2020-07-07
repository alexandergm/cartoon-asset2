using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsController : MonoBehaviour
{
    [SerializeField] private bool _starDisabled = false;
    [SerializeField] private Image[] _stars;
    [SerializeField] private float _timeOnStar = 5;
    private Image _currentStar;
    private int _countStar;
    private bool _isTimerStopped = true;
    private float _fillAmount;
    void Start()
    {
        if (_starDisabled)
        {
            GameObject.Find("Canvas").SetActive(false);
        }
        
        _countStar = 0;
        _currentStar = _stars[_countStar];
    }

    // Update is called once per frame
    void Update()
    {
        if (_isTimerStopped) return;
        
        _currentStar.fillAmount -= Time.deltaTime / _timeOnStar;
        if (_currentStar.fillAmount <= 0)
        {
            _countStar++;
            if (_countStar < _stars.Length)
            {
                _currentStar = _stars[_countStar];
                _currentStar.fillAmount = _fillAmount;
                return;
            }

            _isTimerStopped = true;

        }
    }

    public void ChangeFillAmount(float fill)
    {
        _fillAmount = _currentStar.fillAmount;
        _currentStar.fillAmount = fill;
    }

    public void StartLevel()
    {
        if (!_starDisabled)
            _isTimerStopped = false;
    }

    public void Stop()
    {
        _isTimerStopped = true;
    }
}
