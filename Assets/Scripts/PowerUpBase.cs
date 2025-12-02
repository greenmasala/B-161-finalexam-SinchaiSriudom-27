using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool isEffectActive;

    public abstract void ApplyEffect(Player player);
}
