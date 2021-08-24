using UnityEngine;
using UnityEngine.UI;

namespace JTools
{
    public class ProgressBar : MonoBehaviour
    {
        private Image fill;


        private void Awake()
        {
            fill = GetComponentInChildren<Image>();
            fill.fillAmount = 0;
        }


        public void SetFill(float amount, float maxAmount)
        {
            fill.fillAmount = amount / maxAmount;
        }
    }
}