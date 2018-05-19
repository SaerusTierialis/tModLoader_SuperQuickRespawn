using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SuperQuickRespawn
{
    class MyPlayer : ModPlayer
    {
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            //short timer
            player.respawnTimer = 300;

            //base
            base.Kill(damage, hitDirection, pvp, damageSource);
        }
    }
}
