using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player != null && !IsEffectActive)
        {
            player.SetInvulnerability(true);
            EffectActive();
        }
    }
}
