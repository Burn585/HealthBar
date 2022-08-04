using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private UnityEvent _changedHealth;
    [SerializeField] private float _value;
    [SerializeField] private float _maxValue;
    [SerializeField] private float _minValue;

    public void Heal()
    {
        float heal = 10;

        _value = Mathf.Clamp(_value + heal, _minValue, _maxValue);
        _changedHealth?.Invoke();
    }

    public void Damage()
    {
        float hit = 10;

        _value = Mathf.Clamp(_value - hit, _minValue, _maxValue);
        _changedHealth?.Invoke();
    }

    public float GetValue()
    {
        return _value;
    }
}