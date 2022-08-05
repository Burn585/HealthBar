using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> _changedHealth;
    public float Value { get; private set; }
    public float MaxValue { get; private set; }
    public float MinValue { get; private set; }

    public Health()
    {
        Value = 50;
        MaxValue = 100;
        MinValue = 0;
    }

    public void Heal(float heal)
    {
        Value = Mathf.Clamp(Value + heal, MinValue, MaxValue);
        _changedHealth?.Invoke(Value);
    }

    public void Damage(float hit)
    {
        Value = Mathf.Clamp(Value - hit, MinValue, MaxValue);
        _changedHealth?.Invoke(Value);
    }
}