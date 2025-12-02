using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player) //overriding abstract method to call for different methods in Player 
    {
        if (player != null && !IsEffectActive)
        {
            player.SetInvulnerability(true);
            EffectActive();
        }
    }
}
