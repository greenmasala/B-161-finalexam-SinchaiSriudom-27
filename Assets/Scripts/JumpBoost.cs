using UnityEngine;

public class JumpBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player != null && !IsEffectActive)
        {
            player.SetJumpForce(2);
            EffectActive();
        }
    }
}
