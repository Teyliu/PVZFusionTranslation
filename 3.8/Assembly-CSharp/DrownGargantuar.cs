using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000653 RID: 1619
[Token(Token = "0x2000653")]
public class DrownGargantuar : Gargantuar
{
	// Token: 0x06001ED2 RID: 7890 RVA: 0x000A4914 File Offset: 0x000A2B14
	[Token(Token = "0x6001ED2")]
	[Address(RVA = "0x540710", Offset = "0x53ED10", VA = "0x180540710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x000A4930 File Offset: 0x000A2B30
	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x000A4940 File Offset: 0x000A2B40
	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x540730", Offset = "0x53ED30", VA = "0x180540730", Slot = "29")]
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

	// Token: 0x06001ED5 RID: 7893 RVA: 0x000A4984 File Offset: 0x000A2B84
	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x540A90", Offset = "0x53F090", VA = "0x180540A90", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		ulong num;
		do
		{
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			bool flag;
			string text;
			if (!flag || !(text != "water"))
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x000A49C0 File Offset: 0x000A2BC0
	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0x540340", Offset = "0x53E940", VA = "0x180540340", Slot = "75")]
	protected override Zombie AnimThrow()
	{
		int num;
		do
		{
			List<GameObject> list = this.weapons;
			num = 0;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				SpriteRenderer spriteRenderer;
				spriteRenderer.enabled = num2 != 0;
			}
		}
		while (num != 0);
		int num3 = 0;
		float num4 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		float num5 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Zombie_drown/weapon");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		drownProjectile.theRow = gameObject2;
		drownProjectile.horizontal = true;
		num3++;
		throw new NullReferenceException();
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x000A4A60 File Offset: 0x000A2C60
	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0x540CF0", Offset = "0x53F2F0", VA = "0x180540CF0")]
	protected void SetWeapon(Vector2 position)
	{
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Zombie_drown/weapon");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		int theZombieRow = this.theZombieRow;
		drownProjectile.theRow = theZombieRow;
		drownProjectile.horizontal = true;
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x000A4AB8 File Offset: 0x000A2CB8
	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0x540910", Offset = "0x53EF10", VA = "0x180540910", Slot = "77")]
	protected override void CrashPlant(Plant plant, bool crash)
	{
		if (!crash)
		{
			plant.FlashOnce();
			return;
		}
		Transform axis = plant.axis;
		GameAPP.PlaySound(75, 0.5f, 1f);
		int num = global::UnityEngine.Random.Range(8, 10);
		plant.Crashed(1, num, this);
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000A4B04 File Offset: 0x000A2D04
	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0x540BF0", Offset = "0x53F1F0", VA = "0x180540BF0")]
	private void InWater()
	{
		Transform axis = this.axis;
		GameAPP.PlaySound(75, 0.5f, 1f);
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000A4B30 File Offset: 0x000A2D30
	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0x540E80", Offset = "0x53F480", VA = "0x180540E80")]
	public DrownGargantuar()
	{
		List<GameObject> list = new List();
		this.weapons = list;
		base..ctor();
	}

	// Token: 0x04001065 RID: 4197
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001065")]
	public List<GameObject> weapons;
}
