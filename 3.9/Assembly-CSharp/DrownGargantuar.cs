using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000689 RID: 1673
[Token(Token = "0x2000689")]
public class DrownGargantuar : Gargantuar
{
	// Token: 0x06001FD4 RID: 8148 RVA: 0x000A9064 File Offset: 0x000A7264
	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0x5A2D40", Offset = "0x5A1340", VA = "0x1805A2D40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant", "TorchWood", "Zombie" });
		this._LayerMask = layerMask;
		this.SetWeapon();
		this.inWater = true;
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000A90C8 File Offset: 0x000A72C8
	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x000A90D8 File Offset: 0x000A72D8
	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0x5A2E60", Offset = "0x5A1460", VA = "0x1805A2E60", Slot = "30")]
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
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
		int num3 = 0;
		if (0 * (int)0.5f > num3)
		{
		}
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x000A9128 File Offset: 0x000A7328
	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0x5A31C0", Offset = "0x5A17C0", VA = "0x1805A31C0", Slot = "29")]
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

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000A9164 File Offset: 0x000A7364
	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0x5A2970", Offset = "0x5A0F70", VA = "0x1805A2970", Slot = "77")]
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

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000A9204 File Offset: 0x000A7404
	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x5A3420", Offset = "0x5A1A20", VA = "0x1805A3420")]
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

	// Token: 0x06001FDA RID: 8154 RVA: 0x000A925C File Offset: 0x000A745C
	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x5A3040", Offset = "0x5A1640", VA = "0x1805A3040", Slot = "79")]
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

	// Token: 0x06001FDB RID: 8155 RVA: 0x000A92A8 File Offset: 0x000A74A8
	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0x5A3320", Offset = "0x5A1920", VA = "0x1805A3320")]
	private void InWater()
	{
		Transform axis = this.axis;
		GameAPP.PlaySound(75, 0.5f, 1f);
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000A92D4 File Offset: 0x000A74D4
	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x5A35B0", Offset = "0x5A1BB0", VA = "0x1805A35B0")]
	public DrownGargantuar()
	{
		List<GameObject> list = new List();
		this.weapons = list;
		base..ctor();
	}

	// Token: 0x04001131 RID: 4401
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001131")]
	public List<GameObject> weapons;
}
