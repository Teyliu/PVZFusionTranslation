using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000500 RID: 1280
[Token(Token = "0x2000500")]
public class Hamburger : Shooter
{
	// Token: 0x060017E3 RID: 6115 RVA: 0x00082054 File Offset: 0x00080254
	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x4CA960", Offset = "0x4C8F60", VA = "0x1804CA960", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (this.thePlantStage == 1)
		{
			GameObject gameObject = this.r1;
			this.thePlantMaxHealth = (int)((ulong)4000L);
			this.thePlantAttackInterval = 2f;
			int num = 0;
			gameObject.SetActive(num != 0);
			GameObject gameObject2 = this.r2;
			GameObject gameObject3 = this.r1;
			this.thePlantMaxHealth = (int)((ulong)3000L);
			this.thePlantAttackInterval = 2.5f;
			int num2 = 0;
			gameObject3.SetActive(num2 != 0);
			GameObject gameObject4 = this.r2;
			int num3 = 0;
			gameObject4.SetActive(num3 != 0);
			GameObject gameObject5 = this.r3;
			GameObject gameObject6 = this.r1;
			this.thePlantMaxHealth = (int)((ulong)2000L);
			this.thePlantAttackInterval = 2.5f;
			int num4 = 0;
			gameObject6.SetActive(num4 != 0);
			ulong num5;
			this.r2.SetActive(num5 != 0UL);
			GameObject gameObject7 = this.r3;
			int num6 = 0;
			gameObject7.SetActive(num6 != 0);
		}
		Animator anim = this.anim;
		int thePlantStage = this.thePlantStage;
		anim.SetInteger("stage", thePlantStage);
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x0008215C File Offset: 0x0008035C
	[Token(Token = "0x60017E4")]
	[Address(RVA = "0x4C9D90", Offset = "0x4C8390", VA = "0x1804C9D90")]
	public int GetMaxHealth(PlantType thePlantType)
	{
		int thePlantStage = this.thePlantStage;
		PlantDataManager.PlantData plantData;
		int num = plantData.maxHealth;
		if (plantData != 0)
		{
			if (plantData == 0)
			{
				return num;
			}
			if (thePlantStage == 1)
			{
				return num;
			}
		}
		else
		{
			num += num;
		}
		return num;
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x00082198 File Offset: 0x00080398
	[Token(Token = "0x60017E5")]
	[Address(RVA = "0x4C9AF0", Offset = "0x4C80F0", VA = "0x1804C9AF0")]
	public bool AddStage(PlantType thePlantType)
	{
		int thePlantStage = this.thePlantStage;
		if (thePlantStage == 0 || thePlantStage == 0 || thePlantStage != 1)
		{
		}
		uint num;
		while (thePlantType != (PlantType)num)
		{
		}
		int num2 = this.thePlantStage;
		Animator anim = this.anim;
		num2++;
		this.thePlantStage = num2;
		anim.SetInteger("stage", num2);
		PlantType thePlantType2 = this.thePlantType;
		int thePlantStage2 = this.thePlantStage;
		PlantDataManager.PlantData plantData;
		int num3 = plantData.maxHealth;
		if (plantData == 0 || plantData == 0 || thePlantStage2 == 1)
		{
			num3 += num3;
		}
		this.thePlantMaxHealth = num3;
		int thePlantStage3 = this.thePlantStage;
		GameObject gameObject5;
		if (thePlantStage2 != 1)
		{
			if (thePlantStage2 != 1)
			{
				if (thePlantStage3 != 1)
				{
					goto IL_010B;
				}
				GameObject gameObject = this.r1;
				int num4 = 0;
				gameObject.SetActive(num4 != 0);
				GameObject gameObject2 = this.r2;
			}
			GameObject gameObject3 = this.r1;
			int num5 = 0;
			gameObject3.SetActive(num5 != 0);
			GameObject gameObject4 = this.r2;
			int num6 = 0;
			gameObject4.SetActive(num6 != 0);
			gameObject5 = this.r3;
			ulong num7;
			gameObject5.SetActive(num7 != 0UL);
		}
		int num8 = 0;
		gameObject5.SetActive(num8 != 0);
		ulong num9;
		gameObject5.SetActive(num9 != 0UL);
		int num10 = 0;
		gameObject5.SetActive(num10 != 0);
		IL_010B:
		throw new NullReferenceException();
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x000822B8 File Offset: 0x000804B8
	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x4CA040", Offset = "0x4C8640", VA = "0x1804CA040", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num = this.attackDamage;
		List<BulletType> list = new List();
		int size = list._size;
		int num2 = 0;
		list._size = 1;
		list._syncRoot = num2;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		list._size = 1;
		if (this.thePlantStage == 1)
		{
			int size7 = list._size;
			list._size = 1;
			int size8 = list._size;
			list._size = 1;
			int size9 = list._size;
			list._size = 1;
			int size10 = list._size;
			list._size = 1;
			int size11 = list._size;
			list._size = 1;
			int size12 = list._size;
			list._size = 1;
			int size13 = list._size;
			list._size = 1;
			int size14 = list._size;
			list._size = 1;
			int size15 = list._size;
			num += 20;
			list._size = 1;
			num += 20;
			int size16 = list._size;
			list._size = 1;
			int size17 = list._size;
			list._size = 1;
			int size18 = list._size;
			list._size = 1;
			num += 10;
		}
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		int num4 = list[num3];
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (num4 == 0)
		{
			if (bullet != 0)
			{
				if (bullet != 0)
				{
					if (bullet != (ulong)1L)
					{
						return bullet;
					}
					BoardAction boardAction = this.board.boardAction;
				}
				BoardAction boardAction2 = this.board.boardAction;
			}
			BoardAction boardAction3 = this.board.boardAction;
		}
		return bullet;
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x000824AC File Offset: 0x000806AC
	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x4CA940", Offset = "0x4C8F40", VA = "0x1804CA940", Slot = "70")]
	protected override Bullet Shoot2()
	{
		return base.AnimShoot();
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x000824C4 File Offset: 0x000806C4
	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x4C9D50", Offset = "0x4C8350", VA = "0x1804C9D50")]
	private void AnimShoot3()
	{
		Bullet bullet = base.AnimShoot();
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x000824DC File Offset: 0x000806DC
	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x4C9D70", Offset = "0x4C8370", VA = "0x1804C9D70")]
	private void AnimShoot4()
	{
		Bullet bullet = base.AnimShoot();
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x000824F4 File Offset: 0x000806F4
	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x4CAB40", Offset = "0x4C9140", VA = "0x1804CAB40", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00082508 File Offset: 0x00080708
	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x4C9F20", Offset = "0x4C8520", VA = "0x1804C9F20", Slot = "37")]
	public override void ProducerUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		if (num > (int)thePlantProduceCountDown)
		{
			float thePlantProduceInterval = this.thePlantProduceInterval;
			this.thePlantProduceCountDown = thePlantProduceInterval;
			int num2 = global::UnityEngine.Random.Range(-2, 3);
			this.thePlantProduceCountDown = (float)num;
			Hamburger.<SunBright>d__12 <SunBright>d__;
			<SunBright>d__.System.IDisposable.Dispose();
			<SunBright>d__.<>1__state = (int)((ulong)0L);
			<SunBright>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x00082588 File Offset: 0x00080788
	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x4CAAD0", Offset = "0x4C90D0", VA = "0x1804CAAD0")]
	protected IEnumerator SunBright()
	{
		Hamburger.<SunBright>d__12 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x000825AC File Offset: 0x000807AC
	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x4C9E30", Offset = "0x4C8430", VA = "0x1804C9E30")]
	private void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x000825E0 File Offset: 0x000807E0
	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public Hamburger()
	{
	}

	// Token: 0x04000DD1 RID: 3537
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DD1")]
	public GameObject r1;

	// Token: 0x04000DD2 RID: 3538
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DD2")]
	public GameObject r2;

	// Token: 0x04000DD3 RID: 3539
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DD3")]
	public GameObject r3;
}
