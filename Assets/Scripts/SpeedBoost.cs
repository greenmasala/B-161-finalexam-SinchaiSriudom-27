using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player) //overriding abstract method to call for different methods in Player 
    {
        if (player != null && !IsEffectActive)
        {
            player.SetMoveSpeed(2);
            EffectActive();
        }
    }
}
