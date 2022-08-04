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

    public void Heal()
    {
        float heal = 10;

        _value = Mathf.Clamp(_value + heal, _minValue, _maxValue);

        _healthView.ChangeHealthValue(_value);
    }

    public void Damage()
    {
        float hit = 10;

        _value = Mathf.Clamp(_value - hit, _minValue, _maxValue);

        _healthView.ChangeHealthValue(_value);
    }
}
