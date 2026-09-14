using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002B2 RID: 690
[Token(Token = "0x20002B2")]
public class BigStar : MonoBehaviour
{
	// Token: 0x06000C1F RID: 3103 RVA: 0x00044BB4 File Offset: 0x00042DB4
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x4197F0", Offset = "0x417DF0", VA = "0x1804197F0")]
	private void Awake()
	{
		this.speedMutiplier = 1f;
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00044BCC File Offset: 0x00042DCC
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x41A6E0", Offset = "0x418CE0", VA = "0x18041A6E0")]
	public static void SetStar(BigStar.BigStarType bigStarType)
	{
		GameObject gameObject;
		if (bigStarType == BigStar.BigStarType.DoomStar)
		{
			gameObject = Resources.Load<GameObject>("Items/DoomStar");
		}
		int num = 0;
		if (gameObject != num)
		{
			Transform transform = Board.Instance.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<BigStar>().type = bigStarType;
		}
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00044C1C File Offset: 0x00042E1C
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x41A810", Offset = "0x418E10", VA = "0x18041A810")]
	private void Start()
	{
		if (this.zombie)
		{
			float num = this.speedX * -1f;
			this.speedX = num;
			Transform transform = base.transform;
		}
		uint num2;
		GameAPP.PlaySound((int)num2, 1f, 1f);
		Board instance = Board.Instance;
		int rowNum;
		if (instance.rowNum != 1)
		{
			rowNum = instance.rowNum;
			float boxYFromRow = Mouse.Instance.GetBoxYFromRow(rowNum);
		}
		Mouse instance2 = Mouse.Instance;
		int num3 = rowNum - 1;
		float boxYFromRow2 = instance2.GetBoxYFromRow(num3);
		Board instance3 = Board.Instance;
		Mouse instance4 = Mouse.Instance;
		int rowNum2 = instance3.rowNum;
		float num4 = instance4.GetBoxYFromRow(rowNum2) * 0.5f;
		this.minY = num4;
		Solar instance5 = Solar.Instance;
		int num5 = 0;
		if (instance5 != num5 && !this.zombie)
		{
			Transform transform2 = base.transform.Find("Particle System");
			int num6 = 0;
			if (transform2 != num6)
			{
				GameObject gameObject = transform2.gameObject;
				bool flag = !GameAPP.config.disableSolarStarEffect;
				gameObject.SetActive(flag);
			}
			this.sun = true;
		}
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00044D40 File Offset: 0x00042F40
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x41AB20", Offset = "0x419120", VA = "0x18041AB20")]
	private void Update()
	{
		if (!this.isLand)
		{
			float deltaTime = Time.deltaTime;
			this.speedY = deltaTime;
			Transform transform = base.transform;
			float deltaTime2 = Time.deltaTime;
			Transform transform2 = base.transform;
			float num = this.speedX;
			float deltaTime3 = Time.deltaTime;
			int num2 = 0;
			int num3 = 0;
			float num4;
			transform2.Rotate((float)num3, (float)num2, num4);
			Transform transform3 = base.transform;
			Vector3 vector;
			if (this.minY > vector.y)
			{
				this.isLand = true;
				int num5 = 0;
				if ((this.zombie ? 1 : 0) != num5)
				{
					this.ZombieCrash();
					throw new NullReferenceException();
				}
				this.Crash();
			}
		}
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00044DE8 File Offset: 0x00042FE8
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x41ACE0", Offset = "0x4192E0", VA = "0x18041ACE0")]
	private void ZombieCrash()
	{
		int num = 0;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		uint num2;
		GameAPP.PlaySound((int)num2, 1f, 1f);
		ScreenShake.TriggerShake(0.15f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		int mask = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				LayerMask layerMask;
				int mask2 = layerMask.m_Mask;
				if (layerMask != 0)
				{
				}
			}
			num++;
		}
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform5 = bullet.transform;
		uint num3;
		bullet.Damage = (int)num3;
		num += 10;
		num++;
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00044EC4 File Offset: 0x000430C4
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x419800", Offset = "0x417E00", VA = "0x180419800")]
	private void Crash()
	{
		int num = 0;
		global::UnityEngine.Object.Destroy(base.gameObject);
		BigStar.BigStarType bigStarType = this.type;
		if (bigStarType == BigStar.BigStarType.SuperStar)
		{
		}
		if (bigStarType == BigStar.BigStarType.UltimateStar)
		{
		}
		int num2;
		int num3;
		num2 += num3;
		bool flag;
		if (flag)
		{
		}
		Collider2D[] array;
		if (this.type != BigStar.BigStarType.SolarStar)
		{
			if ((this.sun ? 1 : 0) != num)
			{
				CreateItem instance = CreateItem.Instance;
				Transform transform = base.transform;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				Vector3 vector;
				GameObject gameObject = instance.SetCoin(num6, num5, num4, num, vector, num != 0);
				num++;
			}
			Transform transform2 = base.transform;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			if (num >= array.Length)
			{
				goto IL_013D;
			}
			bool flag2;
			if (flag2)
			{
				PlantType plantType = this.fromType;
			}
			num++;
		}
		if ("{il2cpp array field local50->}" != num)
		{
			Player player = PlayerShootingManager.Instance.player;
		}
		if (array[9] > 0)
		{
			Collider2D collider2D = array[9];
			int num7 = 0;
			Zombie zombie;
			if (zombie != num7 && (zombie.isMindControlled ? 1 : 0) == num && zombie.theStatus != ZombieStatus.Dying)
			{
				PlantType plantType2 = this.fromType;
			}
		}
		CreateItem instance2 = CreateItem.Instance;
		Transform transform3 = base.transform;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		Vector3 vector2;
		GameObject gameObject2 = instance2.SetCoin(num10, num9, num8, num, vector2, num != 0);
		num++;
		IL_013D:
		uint num11;
		GameAPP.PlaySound((int)num11, 1f, 1f);
		if (this.type == BigStar.BigStarType.SuperStar)
		{
			Transform transform4 = base.transform;
			GameObject gameObject3;
			Transform transform5 = gameObject3.transform;
			if ((GameAPP.config.distablexplodeFlash ? 1 : 0) == num)
			{
				Transform transform6 = base.transform;
			}
			ParticleManager instance3 = ParticleManager.Instance;
			Transform transform7 = base.transform;
		}
		ParticleManager instance4 = ParticleManager.Instance;
		Transform transform8 = base.transform;
		ParticleManager instance5 = ParticleManager.Instance;
		Transform transform9 = base.transform;
		Transform transform10 = base.transform;
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00045094 File Offset: 0x00043294
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x41A220", Offset = "0x418820", VA = "0x18041A220")]
	private void CreateStars(BulletType bulletType)
	{
		if (this.type <= BigStar.BigStarType.SolarStar)
		{
		}
		if (this.bulletDamage != (ulong)0L)
		{
		}
		int num = 0;
		int num2;
		if (this.type != BigStar.BigStarType.SuperStar)
		{
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			Transform transform3 = bullet.transform;
			bullet.Damage = num2;
			PlantType plantType = this.fromType;
			num += 10;
			float trackSpeed = bullet.trackSpeed;
			bullet.fromType = plantType;
			float num3 = trackSpeed * this.speedMutiplier;
			bullet.trackSpeed = num3;
			num++;
			return;
		}
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet2;
		Transform transform6 = bullet2.transform;
		bullet2.Damage = num2;
		bullet2.theStatus = (BulletStatus)((ulong)4L);
		PlantType plantType2 = this.fromType;
		bullet2.fromType = plantType2;
		throw new NullReferenceException();
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0004516C File Offset: 0x0004336C
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x41B210", Offset = "0x419810", VA = "0x18041B210")]
	public BigStar()
	{
	}

	// Token: 0x04000807 RID: 2055
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000807")]
	private readonly float g = -9.8f;

	// Token: 0x04000808 RID: 2056
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000808")]
	private float speedX = 7f;

	// Token: 0x04000809 RID: 2057
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000809")]
	private float speedY;

	// Token: 0x0400080A RID: 2058
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400080A")]
	private bool isLand;

	// Token: 0x0400080B RID: 2059
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400080B")]
	private float minY;

	// Token: 0x0400080C RID: 2060
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400080C")]
	public BigStar.BigStarType type;

	// Token: 0x0400080D RID: 2061
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400080D")]
	public bool zombie;

	// Token: 0x0400080E RID: 2062
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400080E")]
	public int baseDamage = (int)((ulong)1800L);

	// Token: 0x0400080F RID: 2063
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400080F")]
	public int? bulletDamage;

	// Token: 0x04000810 RID: 2064
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000810")]
	public int skinType;

	// Token: 0x04000811 RID: 2065
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000811")]
	private bool sun;

	// Token: 0x04000812 RID: 2066
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000812")]
	public PlantType fromType;

	// Token: 0x04000813 RID: 2067
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000813")]
	public float speedMutiplier;

	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public enum BigStarType
	{
		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		Default,
		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		SuperStar,
		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		UltimateStar,
		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		IronStar,
		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		PickaxeStar,
		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		SolarStar,
		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		DoomStar
	}
}
