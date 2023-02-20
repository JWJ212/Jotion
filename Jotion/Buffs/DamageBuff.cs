using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Jotion.Buffs
{
    public class DamageBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("James Power");
            Description.SetDefault("Holy Fuck.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) += 5000.0f;
            player.moveSpeed += 50;
            player.AddBuff(44, 4500, false);
        }
    }
}