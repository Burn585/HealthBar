using UnityEngine;

[RequireComponent(typeof(HealthView))]

public class Health : MonoBehaviour
{
    [SerializeField] private float _value;
    [SerializeField] private float _maxValue;
    [SerializeField] private float _minValue;

    private HealthView _healthView;

    private void Start()
    {
        _healthView = GetComponent<HealthView>();
    }

    public void Healing()
    {
        float heal = 10;

        if (_value + heal > _maxValue) 
        {
            _value = _maxValue;
        }
        else
        {
            _value += heal;
        }

        _healthView.ChangeHealthValue(_value);
    }

    public void Damage()
    {
        float hit = 10;

        if(_value - hit < _minValue)
        {
            _value = _minValue;
        }
        else
        {
            _value -= hit;
        }

        _healthView.ChangeHealthValue(_value);
    }
}
