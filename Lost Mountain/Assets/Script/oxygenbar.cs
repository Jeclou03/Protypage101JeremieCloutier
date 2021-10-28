
using UnityEngine;
using UnityEngine.UI;

public class oxygenbar : MonoBehaviour
{
    #region
    public Slider SliderBar;

    #endregion
    //----------------
    public void SetMaxHealth(int health)
    {
        SliderBar.maxValue = health;
        SliderBar.value = health;
    }

    public void SetHealth(int health)
    {
        SliderBar.value = health;
    }
}

