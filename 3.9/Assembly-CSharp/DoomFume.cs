using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000509 RID: 1289
[Token(Token = "0x2000509")]
public class DoomFume : Plant
{
	// Token: 0x0600183A RID: 6202 RVA: 0x00083B64 File Offset: 0x00081D64
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x5214A0", Offset = "0x51FAA0", VA = "0x1805214A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("backToIdle");
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x00083B88 File Offset: 0x00081D88
	[Token(Token = "0x600183B")]
	[Address(RVA = "0x5214F0", Offset = "0x51FAF0", VA = "0x1805214F0")]
	public void Shoot()
	{
		this.anim.SetTrigger("shoot");
		this.theStatus = (PlantStatus)((ulong)15L);
		base.AttributeCountdown = 30f;
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x00083BC4 File Offset: 0x00081DC4
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x521030", Offset = "0x51F630", VA = "0x180521030")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[31];
		Transform transform = this.board.transform;
		GameObject gameObject2;
		Renderer component = gameObject2.GetComponent<ParticleSystem>().GetComponent<Renderer>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		GameAPP.PlaySound(58, 0.5f, 1f);
		this.AttackZombie();
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x00083C48 File Offset: 0x00081E48
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x521290", Offset = "0x51F890", VA = "0x180521290")]
	private void AttackZombie()
	{
		Board board = this.board;
		int num = 0;
		int size = board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			int num3 = 0;
			if (zombie != num3)
			{
				Transform axis = zombie.axis;
				Transform axis2 = this.axis;
				if (base.SearchUniqueZombie(zombie))
				{
					int thePlantRow = this.thePlantRow;
					if (zombie.theZombieRow == thePlantRow)
					{
						PlantType thePlantType = this.thePlantType;
					}
				}
			}
			if (num != 0)
			{
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
			}
		}
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x00083CEC File Offset: 0x00081EEC
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomFume()
	{
	}
}
