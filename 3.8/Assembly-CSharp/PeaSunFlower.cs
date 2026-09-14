using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032F RID: 815
[Token(Token = "0x200032F")]
public class PeaSunFlower : Shooter
{
	// Token: 0x06000EDD RID: 3805 RVA: 0x00056FB0 File Offset: 0x000551B0
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x4287A0", Offset = "0x426DA0", VA = "0x1804287A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
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
				PeaSunFlower.<SunBright>d__3 <SunBright>d__;
				<SunBright>d__.System.IDisposable.Dispose();
				<SunBright>d__.<>1__state = (int)((ulong)0L);
				<SunBright>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
				base.Invoke("ProduceSun", 0.5f);
			}
		}
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00057040 File Offset: 0x00055240
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x4285D0", Offset = "0x426BD0", VA = "0x1804285D0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		Bullet bullet;
		if (num == 3)
		{
			this.attributeCount = (int)((ulong)0L);
			bullet.theStatus = (BulletStatus)num;
		}
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x000570C4 File Offset: 0x000552C4
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x4283C0", Offset = "0x4269C0", VA = "0x1804283C0")]
	private void PeaSunProduceUpdate()
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
			PeaSunFlower.<SunBright>d__3 <SunBright>d__;
			<SunBright>d__.System.IDisposable.Dispose();
			<SunBright>d__.<>1__state = (int)((ulong)0L);
			<SunBright>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00057144 File Offset: 0x00055344
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x428730", Offset = "0x426D30", VA = "0x180428730")]
	private IEnumerator SunBright()
	{
		PeaSunFlower.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00057168 File Offset: 0x00055368
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x4284E0", Offset = "0x426AE0", VA = "0x1804284E0", Slot = "73")]
	protected virtual void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0005719C File Offset: 0x0005539C
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PeaSunFlower()
	{
	}
}
