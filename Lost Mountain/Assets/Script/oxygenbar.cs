using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    public Slider SliderBar;
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

