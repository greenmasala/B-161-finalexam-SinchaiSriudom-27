using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    private bool isEffectActive;
    public bool IsEffectActive //again, variable with property that can only be changed via a method 
    {
        get { return isEffectActive; }
        protected set { isEffectActive = value; }
    }

    public abstract void ApplyEffect(Player player); //abstract void to allow for derived classes to have their own unique effects when ApplyEffect() is called 

    public void EffectActive()
    {
        IsEffectActive = true;
        Debug.Log($"{this} active status: {IsEffectActive}");
    }
}
