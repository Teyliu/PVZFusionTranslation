using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E1 RID: 1249
[Token(Token = "0x20004E1")]
public class DoomFume : Plant
{
	// Token: 0x06001783 RID: 6019 RVA: 0x00080910 File Offset: 0x0007EB10
	[Token(Token = "0x6001783")]
	[Address(RVA = "0x4A1970", Offset = "0x49FF70", VA = "0x1804A1970", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("backToIdle");
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00080934 File Offset: 0x0007EB34
	[Token(Token = "0x6001784")]
	[Address(RVA = "0x4A19C0", Offset = "0x49FFC0", VA = "0x1804A19C0")]
	public void Shoot()
	{
		this.anim.SetTrigger("shoot");
		this.theStatus = (PlantStatus)((ulong)15L);
		base.AttributeCountdown = 30f;
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00080970 File Offset: 0x0007EB70
	[Token(Token = "0x6001785")]
	[Address(RVA = "0x4A1500", Offset = "0x49FB00", VA = "0x1804A1500")]
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

	// Token: 0x06001786 RID: 6022 RVA: 0x000809F4 File Offset: 0x0007EBF4
	[Token(Token = "0x6001786")]
	[Address(RVA = "0x4A1760", Offset = "0x49FD60", VA = "0x1804A1760")]
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

	// Token: 0x06001787 RID: 6023 RVA: 0x00080A98 File Offset: 0x0007EC98
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomFume()
	{
	}
}
