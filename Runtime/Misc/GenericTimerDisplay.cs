using System;
using TMPro;
using UnityEngine;

namespace JTools
{
    public class GenericTimerDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text timerText;
        [SerializeField] private float startTime;
        [SerializeField] private float timer;
        [SerializeField] private bool isTimerRunning;
        [SerializeField] private Gradient timerCol;


        public static event Action OnTimerEnded;
        
        
        private void Start()
        {
            timer = 15;
            isTimerRunning = true;
        }


        private void Update()
        {
            Timer();
            TimerDisplay();
        }
        

        private void Timer()
        {
            if (!isTimerRunning) return;
            timer -= Time.deltaTime;
            if (!(timer < 0)) return;
            WhenTimerComplete();
        }


        private void WhenTimerComplete()
        {
            OnTimerEnded?.Invoke();
        }

        
        private void TimerDisplay()
        {
            if (timer >= 10)
                timerText.text = timer.ToString("c").Substring(1, 5);
            else
                timerText.text = timer.ToString("c").Substring(1, 4);
            
            timerText.color = timerCol.Evaluate(1 - (timer / startTime));
        }
        
        
        public void AddToTimer(float value)
        {
            timer += value;
        }


        public void SetTimer(float value)
        {
            timer = value;
        }
    }
}