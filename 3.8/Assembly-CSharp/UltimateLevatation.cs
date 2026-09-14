using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000702 RID: 1794
[Token(Token = "0x2000702")]
public class UltimateLevatation : Zombie
{
	// Token: 0x060023D5 RID: 9173 RVA: 0x000BB280 File Offset: 0x000B9480
	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x58A8E0", Offset = "0x588EE0", VA = "0x18058A8E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)10L);
		this.attributeCountDown = 1f;
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x000BB2A8 File Offset: 0x000B94A8
	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x58A720", Offset = "0x588D20", VA = "0x18058A720", Slot = "23")]
	protected override void AttributeEvent()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (Lawnf.ThrowLandStatus((ZombieStatus)num))
				{
				}
			}
			num++;
		}
		this.attributeCountDown = 1f;
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x000BB30C File Offset: 0x000B950C
	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x58A910", Offset = "0x588F10", VA = "0x18058A910", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x000BB348 File Offset: 0x000B9548
	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x58AAC0", Offset = "0x5890C0", VA = "0x18058AAC0", Slot = "45")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x000BB388 File Offset: 0x000B9588
	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060023DA RID: 9178 RVA: 0x000BB398 File Offset: 0x000B9598
	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x58ABD0", Offset = "0x5891D0", VA = "0x18058ABD0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		Transform axis = this.axis;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
			}
			num++;
		}
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x000BB3E4 File Offset: 0x000B95E4
	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x58AA80", Offset = "0x589080", VA = "0x18058AA80")]
	private bool CheckPlant(Plant plant)
	{
		int theZombieRow = this.theZombieRow;
		if (plant.thePlantRow != theZombieRow)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x000BB40C File Offset: 0x000B960C
	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x58AD40", Offset = "0x589340", VA = "0x18058AD40")]
	public UltimateLevatation()
	{
	}
}
