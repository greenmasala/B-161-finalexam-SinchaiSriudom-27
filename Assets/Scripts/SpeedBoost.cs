using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player != null)
        {
            player.SetMoveSpeed(2);
            isEffectActive = true;
        }
    }
}
