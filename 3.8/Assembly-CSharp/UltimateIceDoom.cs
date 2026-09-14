using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000475 RID: 1141
[Token(Token = "0x2000475")]
public class UltimateIceDoom : Plant
{
	// Token: 0x06001527 RID: 5415 RVA: 0x000752E0 File Offset: 0x000734E0
	[Token(Token = "0x6001527")]
	[Address(RVA = "0x488A40", Offset = "0x487040", VA = "0x180488A40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.UpdateSprite();
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x000752FC File Offset: 0x000734FC
	[Token(Token = "0x6001528")]
	[Address(RVA = "0x488770", Offset = "0x486D70", VA = "0x180488770", Slot = "36")]
	protected override bool OnCrash()
	{
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		this.Explode(thePlantColumn, thePlantRow);
		return true;
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00075320 File Offset: 0x00073520
	[Token(Token = "0x6001529")]
	[Address(RVA = "0x488090", Offset = "0x486690", VA = "0x180488090", Slot = "40")]
	protected override void AttributeEvent()
	{
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		this.Explode(thePlantColumn, thePlantRow);
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00075344 File Offset: 0x00073544
	[Token(Token = "0x600152A")]
	[Address(RVA = "0x488790", Offset = "0x486D90", VA = "0x180488790")]
	public void SetTarget(int theColumn, int theRow)
	{
		int num = 0;
		int num2 = 0;
		base.AttributeCountdown = (float)num;
		this.anim.SetTrigger("portal");
		GameAPP.PlaySound(95, 0.5f, 1f);
		this.targetColumn = theColumn;
		this.targetRow = theRow;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.targetColumn);
		Mouse instance = Mouse.Instance;
		int num3 = this.targetRow;
		float landY = instance.GetLandY(boxXFromColumn, num3);
		Transform transform = this.portalOut.transform;
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform2 = this.portalIn.transform;
		int num4 = 0;
		Vector3 vector;
		float z = vector.z;
		ulong num5;
		Particle particle = instance2.SetParticle(ParticleType.RandomCloud, num4, 11, num5 != 0UL, (float)num2);
		ParticleManager instance3 = ParticleManager.Instance;
		Transform transform3 = this.portalOut.transform;
		int num6 = 0;
		ulong num7;
		Particle particle2 = instance3.SetParticle(ParticleType.RandomCloud, num6, 11, num7 != 0UL, (float)num2);
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00075428 File Offset: 0x00073628
	[Token(Token = "0x600152B")]
	[Address(RVA = "0x488010", Offset = "0x486610", VA = "0x180488010")]
	private void AnimPortal()
	{
		int num = this.targetRow;
		int num2 = this.targetColumn;
		this.Explode(num2, num);
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x0007544C File Offset: 0x0007364C
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x488030", Offset = "0x486630", VA = "0x180488030")]
	private void AnimPreExplode()
	{
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x0007546C File Offset: 0x0007366C
	[Token(Token = "0x600152D")]
	[Address(RVA = "0x488720", Offset = "0x486D20", VA = "0x180488720")]
	public bool LevelUp()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num == 2)
		{
			base.AttributeCountdown = 10f;
		}
		this.UpdateSprite();
		return true;
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x000754A8 File Offset: 0x000736A8
	[Token(Token = "0x600152E")]
	[Address(RVA = "0x4880B0", Offset = "0x4866B0", VA = "0x1804880B0")]
	private void Explode(int theColumn, int theRow)
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		int attributeCount = this.attributeCount;
		int attackDamage = this.attackDamage;
		if (attributeCount != 0)
		{
			if (attributeCount != 0)
			{
				if (attributeCount != 1)
				{
					goto IL_00DC;
				}
				Board board = this.board;
				int num2 = 0;
				board.iceDoomFreezeTime = 10f;
				Func<Zombie, bool> func;
				IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetZombiesByRow(theRow, num2 != 0), func);
				Func<Zombie, int> <>9__13_ = UltimateIceDoom.<>c.<>9__13_1;
				if (<>9__13_ == 0)
				{
					Func<Zombie, int> func2;
					UltimateIceDoom.<>c.<>9__13_1 = func2;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, int>(enumerable, <>9__13_));
				int num3 = 0;
				if (zombie != num3)
				{
					zombie.SetPortaled(30f);
					num3 += num3;
				}
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
			}
			this.board.iceDoomFreezeTime = 3f;
		}
		this.board.iceDoomFreezeTime = 1f;
		IL_00DC:
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		float num4 = Lawnf.GetBoxXFromColumn(theColumn);
		float num5 = Mouse.Instance.GetLandY(num4, theRow);
		Board board2 = this.board;
		num5 = num4;
		if (this.portalIn.activeSelf)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = this.portalIn.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform transform2 = this.portalOut.transform;
			num4 = num5;
		}
		int attackDamage2 = this.attackDamage;
		bool flag;
		uint num7;
		if (!flag)
		{
			uint num6;
			ConnectPortal connectPortal = ConnectPortal.CreatePortalGroups((int)num6, (int)num7, num4, 10f, attackDamage2);
			return;
		}
		num7 += num7;
		throw new NullReferenceException();
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x0007564C File Offset: 0x0007384C
	[Token(Token = "0x600152F")]
	[Address(RVA = "0x488A60", Offset = "0x487060", VA = "0x180488A60")]
	private void UpdateSprite()
	{
		for (;;)
		{
			int num = 0;
			int attributeCount = this.attributeCount;
			if (attributeCount == 0 || attributeCount != 1)
			{
				List<GameObject> list = this.bodies;
				bool flag;
				if (flag)
				{
					Lawnf.ChangeSprite(3f, 3f, num);
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					continue;
				}
			}
			List<GameObject> list2 = this.bodies;
			bool flag2;
			ulong num3;
			if (flag2)
			{
				Lawnf.ChangeSprite((float)num3, 3f, num);
			}
			if (num3 == (ulong)0L)
			{
				bool flag3;
				if (flag3)
				{
					Lawnf.ChangeSprite(1f, 3f, num);
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x000756D0 File Offset: 0x000738D0
	[Token(Token = "0x6001530")]
	[Address(RVA = "0x488D50", Offset = "0x487350", VA = "0x180488D50")]
	public UltimateIceDoom()
	{
		List<GameObject> list = new List();
		this.bodies = list;
		base..ctor();
	}

	// Token: 0x04000CF8 RID: 3320
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CF8")]
	public GameObject targetPrefab;

	// Token: 0x04000CF9 RID: 3321
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CF9")]
	public List<GameObject> bodies;

	// Token: 0x04000CFA RID: 3322
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CFA")]
	public GameObject portalIn;

	// Token: 0x04000CFB RID: 3323
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CFB")]
	public GameObject portalOut;

	// Token: 0x04000CFC RID: 3324
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000CFC")]
	private int targetColumn;

	// Token: 0x04000CFD RID: 3325
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000CFD")]
	private int targetRow;
}
