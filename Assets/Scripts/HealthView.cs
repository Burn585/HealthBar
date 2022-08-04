using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthView : MonoBehaviour
{
    private Slider _slider;
    private float _currentValue;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if(_currentValue != _slider.value)
        {

        }
    }

    public void ChangeHealthValue(float value)
    {
        StartCoroutine(ChangeSliderValue(_slider, value));
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
