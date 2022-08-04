using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(Health))]

public class HealthView : MonoBehaviour
{
    private Health _health;
    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _health = GetComponent<Health>();
    }

    public void ChangeHealthValue()
    {
        StartCoroutine(ChangeSliderValue(_slider, _health.GetValue()));
    }

    private IEnumerator ChangeSliderValue(Slider slider, float value)
    {
        float delta = 0.1f;

        while(slider.value != value)
        {
            slider.value = Mathf.MoveTowards(slider.value, value, delta);
            yield return null;
        }
    }
}