using System;
using System.Collections;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005A9 RID: 1449
[Token(Token = "0x20005A9")]
public class UltimateFume : IceDoomFume
{
	// Token: 0x06001AE5 RID: 6885 RVA: 0x00090408 File Offset: 0x0008E608
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x4FD090", Offset = "0x4FB690", VA = "0x1804FD090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SortingGroup sortingGroup = this.particle.AddComponent<SortingGroup>();
		sortingGroup.sortAtRoot = true;
		sortingGroup.sortingLayerName = "particle11";
		SortingGroup sortingGroup2 = this.particle2.AddComponent<SortingGroup>();
		sortingGroup2.sortAtRoot = true;
		sortingGroup2.sortingLayerName = "particle11";
		ParticleSystem.MainModule main = this.particle.main;
		this.emission = main;
		ParticleSystem.MainModule main2 = this.particle2.main;
		this.emission2 = main2;
		throw new NullReferenceException();
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x00090484 File Offset: 0x0008E684
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x4FD280", Offset = "0x4FB880", VA = "0x1804FD280", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		Animator anim = this.anim;
		GameObject gameObject = this.SearchZombie();
		int num = 0;
		if (gameObject != num)
		{
		}
		Zombie zombie = base.SearchBoss();
		int num2 = 0;
		bool flag = zombie != num2;
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x000904F0 File Offset: 0x0008E6F0
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x4FD3B0", Offset = "0x4FB9B0", VA = "0x1804FD3B0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		return base.SearchZombie();
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x00090564 File Offset: 0x0008E764
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x4FD1E0", Offset = "0x4FB7E0", VA = "0x1804FD1E0")]
	private void EnableParticle()
	{
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x00090574 File Offset: 0x0008E774
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x4FD1B0", Offset = "0x4FB7B0", VA = "0x1804FD1B0")]
	private void DisableParticle()
	{
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x00090584 File Offset: 0x0008E784
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x4FCC30", Offset = "0x4FB230", VA = "0x1804FCC30")]
	private void AttackZombie2()
	{
		if (Lawnf.TravelUltimate((UltiBuff)((uint)4)))
		{
			this.AttackZombie();
			return;
		}
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000905A4 File Offset: 0x0008E7A4
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x4FCC60", Offset = "0x4FB260", VA = "0x1804FCC60")]
	private void AttackZombie()
	{
		int num = 0;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		float num2 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		Transform shoot2 = this.shoot;
		float num3 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		PlantType thePlantType = this.thePlantType;
		num++;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int size = this.board.zombieArray._size;
		int num4 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num4];
			int num5 = 0;
			if (zombie != num5)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled)
				{
					Transform axis = zombie.axis;
					Transform axis2 = this.axis;
					if (Lawnf.InLandStatus(zombie.theStatus))
					{
						PlantType thePlantType2 = this.thePlantType;
						int num6 = 0;
						zombie.AddfreezeLevel(20, num6);
						this.TrySetMindControl(zombie);
					}
				}
			}
			if ((ulong)1L != 0UL)
			{
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
				UltimateFume.<StarAttack>d__11 <StarAttack>d__;
				<StarAttack>d__.System.IDisposable.Dispose();
				<StarAttack>d__.<>1__state = (int)((ulong)1L);
				<StarAttack>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<StarAttack>d__);
			}
		}
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x000906E4 File Offset: 0x0008E8E4
	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x4FD910", Offset = "0x4FBF10", VA = "0x1804FD910")]
	private IEnumerator StarAttack()
	{
		UltimateFume.<StarAttack>d__11 <StarAttack>d__;
		<StarAttack>d__.System.IDisposable.Dispose();
		<StarAttack>d__.<>1__state = (int)((ulong)0L);
		<StarAttack>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00090708 File Offset: 0x0008E908
	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x4FD210", Offset = "0x4FB810", VA = "0x1804FD210", Slot = "57")]
	protected override bool OnStarUp()
	{
		Animator anim = this.anim;
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		int num = 0;
		anim.SetBool("shooting", num != 0);
		return true;
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00090744 File Offset: 0x0008E944
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x4FD980", Offset = "0x4FBF80", VA = "0x1804FD980")]
	private void TrySetMindControl(Zombie zombie)
	{
		if (zombie <= 0)
		{
		}
		float value = global::UnityEngine.Random.value;
		if (zombie <= 0)
		{
		}
		int num = 0;
		zombie.SetMindControl(num);
		this.SmallDoom(zombie);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		if (zombie.isMindControlled && zombie.BoxType != BoxType.Water)
		{
			CreateZombie instance = CreateZombie.Instance;
			Transform axis = zombie.axis;
			bool flag;
			bool flag2;
			if (!flag || flag2)
			{
			}
			uint num3;
			zombie.Die((int)num3);
		}
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000907C0 File Offset: 0x0008E9C0
	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x4FD6C0", Offset = "0x4FBCC0", VA = "0x1804FD6C0")]
	private void SmallDoom(Zombie z)
	{
		Transform axis = z.axis;
		Vector3 vector;
		float z2 = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus(z.theStatus))
			{
				int theZombieRow = z.theZombieRow;
				PlantType thePlantType = this.thePlantType;
			}
			num3++;
		}
		Transform axis2 = z.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00090840 File Offset: 0x0008EA40
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public UltimateFume()
	{
	}

	// Token: 0x04000EA2 RID: 3746
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EA2")]
	public ParticleSystem particle;

	// Token: 0x04000EA3 RID: 3747
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EA3")]
	public ParticleSystem particle2;

	// Token: 0x04000EA4 RID: 3748
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000EA4")]
	private ParticleSystem.EmissionModule emission;

	// Token: 0x04000EA5 RID: 3749
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000EA5")]
	private ParticleSystem.EmissionModule emission2;
}
