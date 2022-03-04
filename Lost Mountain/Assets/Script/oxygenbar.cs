
using UnityEngine;
using UnityEngine.UI;

public class oxygenbar : MonoBehaviour
{
    #region
    public Slider SliderBar;
    #endregion
    //----------------
    //max d oxygen au commencement de la partie
    public void SetMaxHealth(int health)
    {
        SliderBar.maxValue = health;
        SliderBar.value = health;
    }

    // uibar reference avec l oxygene du joueur
    public void SetHealth(int health)
    {
        SliderBar.value = health;
    }
}

