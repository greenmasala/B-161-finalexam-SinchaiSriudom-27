using UnityEngine;

public class JumpBoost : PowerUpBase
{
    public override void ApplyEffect(Player player) //overriding abstract method to call for different methods in Player (ABSTRACTION)
    {
        if (player != null && !IsEffectActive)
        {
            player.SetJumpForce(2);
            EffectActive();
        }
    }
}
