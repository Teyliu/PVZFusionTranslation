using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000653 RID: 1619
[Token(Token = "0x2000653")]
public class ArmedGargantuar : Gargantuar
{
	// Token: 0x06001E9A RID: 7834 RVA: 0x000A3AF0 File Offset: 0x000A1CF0
	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x586520", Offset = "0x584B20", VA = "0x180586520", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.SetEyeType();
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x000A3B0C File Offset: 0x000A1D0C
	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x586CE0", Offset = "0x5852E0", VA = "0x180586CE0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		if (this.eyeType == ArmedGargantuar.EyeType.Blue || this.full1)
		{
			float theOriginSpeed = this.theOriginSpeed;
			this.theOriginSpeed = theOriginSpeed;
			if (this.full1)
			{
				goto IL_0038;
			}
		}
		if (this.eyeType != ArmedGargantuar.EyeType.Red)
		{
			return;
		}
		IL_0038:
		float theArmor = this.theArmor;
		this.theArmor = theArmor;
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x000A3B60 File Offset: 0x000A1D60
	[Token(Token = "0x6001E9C")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x000A3B70 File Offset: 0x000A1D70
	[Token(Token = "0x6001E9D")]
	[Address(RVA = "0x5863D0", Offset = "0x5849D0", VA = "0x1805863D0", Slot = "78")]
	protected override void AnimCrash()
	{
		base.AnimCrash();
		if (this.eyeType == ArmedGargantuar.EyeType.Green || this.full1)
		{
			float num = (float)(0 * (int)0.2f);
			this.theHealth = "jump";
			long theMaxHealth = this.theMaxHealth;
			this.theHealth = theMaxHealth;
			GameObject theFirstArmor = this.theFirstArmor;
			int num2 = 0;
			bool flag = theFirstArmor != num2;
			if (flag)
			{
				int num3 = this.theFirstArmorHealth;
				num3 -= (flag ? 1 : 0);
				this.theFirstArmorHealth = num3;
				int theFirstArmorMaxHealth = this.theFirstArmorMaxHealth;
				this.theFirstArmorHealth = theFirstArmorMaxHealth;
			}
			base.UpdateHealthText();
		}
		if (this.eyeType == ArmedGargantuar.EyeType.Yellow || this.full1)
		{
			this.anim.SetTrigger("jump");
			return;
		}
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x000A3C24 File Offset: 0x000A1E24
	[Token(Token = "0x6001E9E")]
	[Address(RVA = "0x5863C0", Offset = "0x5849C0", VA = "0x1805863C0")]
	private void AnimCrash2()
	{
		base.AnimCrash();
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x000A3C38 File Offset: 0x000A1E38
	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x5866D0", Offset = "0x584CD0", VA = "0x1805866D0", Slot = "79")]
	protected override void CrashPlant(Plant plant, bool crash)
	{
		Zombie zombie;
		ArmedGargantuar.EyeType eyeType;
		for (;;)
		{
			if (!crash)
			{
				plant.FlashOnce();
				if (this.eyeType == ArmedGargantuar.EyeType.Blue || this.full1 == crash)
				{
				}
				while (this.full1 != crash)
				{
				}
			}
			bool flag;
			if (!flag)
			{
				return;
			}
			Transform axis = plant.axis;
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			if (!(zombie != num))
			{
				return;
			}
			this.board.SetHealthInTravel(zombie);
			eyeType = this.eyeType;
			if (eyeType == ArmedGargantuar.EyeType.Red || eyeType == ArmedGargantuar.EyeType.Red)
			{
				goto IL_00A4;
			}
			if (eyeType != ArmedGargantuar.EyeType.Red)
			{
				break;
			}
			CreateZombie instance2 = CreateZombie.Instance;
			int num2 = 0;
			Zombie zombie2;
			if (zombie2 != num2)
			{
				goto IL_00A4;
			}
		}
		if (eyeType == ArmedGargantuar.EyeType.Blue)
		{
			int num3 = zombie.theAttackDamage;
			num3 += num3;
			zombie.theAttackDamage = num3;
		}
		return;
		IL_00A4:
		throw new NullReferenceException();
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x000A3CF0 File Offset: 0x000A1EF0
	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x586CA0", Offset = "0x5852A0", VA = "0x180586CA0", Slot = "51")]
	public override void SetJalaed()
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Red)
		{
			base.SetJalaed();
			return;
		}
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x000A3D10 File Offset: 0x000A1F10
	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x586A80", Offset = "0x585080", VA = "0x180586A80", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Blue)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x000A3D30 File Offset: 0x000A1F30
	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x586C80", Offset = "0x585280", VA = "0x180586C80", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Blue)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x000A3D54 File Offset: 0x000A1F54
	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x5866B0", Offset = "0x584CB0", VA = "0x1805866B0", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Yellow)
		{
			base.Buttered(time, sprite);
			return;
		}
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x000A3D74 File Offset: 0x000A1F74
	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x586CC0", Offset = "0x5852C0", VA = "0x180586CC0", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Green)
		{
			base.SetPoison(time);
			return;
		}
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x000A3D94 File Offset: 0x000A1F94
	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x5863A0", Offset = "0x5849A0", VA = "0x1805863A0", Slot = "55")]
	public override void AddPoisonLevel()
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Green)
		{
			base.AddPoisonLevel();
			return;
		}
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x000A3DB4 File Offset: 0x000A1FB4
	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x586A60", Offset = "0x585060", VA = "0x180586A60", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Blue)
		{
			base.KnockBack(x, reason);
			return;
		}
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x000A3DD4 File Offset: 0x000A1FD4
	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x000A3DE4 File Offset: 0x000A1FE4
	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x586AA0", Offset = "0x5850A0", VA = "0x180586AA0")]
	private void SetEyeType()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)24));
		this.full1 = flag;
		Array values = Enum.GetValues(typeof(ArmedGargantuar.EyeType));
		if (values == 0 || values != 0)
		{
			List<ArmedGargantuar.EyeType> list = Enumerable.ToList<ArmedGargantuar.EyeType>(values);
			int num = list._size;
			num = global::UnityEngine.Random.Range(0, num);
			ArmedGargantuar.EyeType eyeType = list[num];
			List<Sprite> list2 = this.headSprites;
			int num2 = (int)eyeType;
			SpriteRenderer spriteRenderer = this.head;
			this.eyeType = eyeType;
			int num3 = (int)eyeType;
			Sprite sprite = list2[num3];
			spriteRenderer.sprite = sprite;
			List<Sprite> list3 = this.helmetSprites;
			SpriteRenderer spriteRenderer2 = this.helmet;
			Sprite sprite2 = list3[num2];
			spriteRenderer2.sprite = sprite2;
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x000A3E98 File Offset: 0x000A2098
	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x586540", Offset = "0x584B40", VA = "0x180586540", Slot = "30")]
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
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000A3ED0 File Offset: 0x000A20D0
	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x586D50", Offset = "0x585350", VA = "0x180586D50")]
	public ArmedGargantuar()
	{
		List<Sprite> list = new List();
		this.headSprites = list;
		List<Sprite> list2 = new List();
		this.helmetSprites = list2;
		base..ctor();
	}

	// Token: 0x040010F0 RID: 4336
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40010F0")]
	private ArmedGargantuar.EyeType eyeType;

	// Token: 0x040010F1 RID: 4337
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40010F1")]
	public SpriteRenderer head;

	// Token: 0x040010F2 RID: 4338
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40010F2")]
	public List<Sprite> headSprites;

	// Token: 0x040010F3 RID: 4339
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40010F3")]
	public SpriteRenderer helmet;

	// Token: 0x040010F4 RID: 4340
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40010F4")]
	public List<Sprite> helmetSprites;

	// Token: 0x040010F5 RID: 4341
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40010F5")]
	private bool full1;

	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	private enum EyeType
	{
		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		Red,
		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		Blue,
		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		Green,
		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		Yellow
	}
}
