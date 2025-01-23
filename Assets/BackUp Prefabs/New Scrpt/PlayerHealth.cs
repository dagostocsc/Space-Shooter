using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    
    public void SetMaxHealth(int health )
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void Health(int health)
    {
        slider.value = health;
    }
}
