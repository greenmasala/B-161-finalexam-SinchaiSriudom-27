using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    private bool isEffectActive;
    public bool IsEffectActive
    {
        get { return isEffectActive; }
        protected set { isEffectActive = value; }
    }

    public abstract void ApplyEffect(Player player);

    public void EffectActive()
    {
        IsEffectActive = true; 
    }
}
