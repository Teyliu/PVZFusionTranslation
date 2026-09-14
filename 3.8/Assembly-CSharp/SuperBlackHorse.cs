using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D9 RID: 1753
[Token(Token = "0x20006D9")]
public class SuperBlackHorse : SuperHorse
{
	// Token: 0x06002287 RID: 8839 RVA: 0x000B4E58 File Offset: 0x000B3058
	[Token(Token = "0x6002287")]
	[Address(RVA = "0x574560", Offset = "0x572B60", VA = "0x180574560", Slot = "74")]
	protected override void AnimFlagUp()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			CreateZombie instance = CreateZombie.Instance;
			Board board2 = this.board;
			num++;
			uint num2;
			num2 += (uint)4;
		}
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x000B4EA4 File Offset: 0x000B30A4
	[Token(Token = "0x6002288")]
	[Address(RVA = "0x574910", Offset = "0x572F10", VA = "0x180574910", Slot = "66")]
	protected override Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		Plant plant = base.CrashEntity(collision, inWater, knockBack);
		int num = 0;
		if (plant != num)
		{
			bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 1f);
		}
		return plant;
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000B4EE0 File Offset: 0x000B30E0
	[Token(Token = "0x6002289")]
	[Address(RVA = "0x574690", Offset = "0x572C90", VA = "0x180574690", Slot = "76")]
	protected override void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		Vector3 vector;
		float z = vector.z;
		int num3 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)121), num2, theZombieRow, num4 != 0UL, (float)num3);
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		int num5 = 0;
		Transform child2 = axis2.GetChild(num5);
		int num6 = 0;
		Zombie zombie;
		if (zombie != num6)
		{
			int theMaxHealth = this.theMaxHealth;
			zombie.theHealth = theMaxHealth;
			int theMaxHealth2 = this.theMaxHealth;
			zombie.theMaxHealth = theMaxHealth2;
		}
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x000B4FAC File Offset: 0x000B31AC
	[Token(Token = "0x600228A")]
	[Address(RVA = "0x5749D0", Offset = "0x572FD0", VA = "0x1805749D0")]
	public SuperBlackHorse()
	{
	}
}
