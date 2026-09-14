using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005B5 RID: 1461
[Token(Token = "0x20005B5")]
public class UltimateLanternSplit : LanternPea
{
	// Token: 0x06001B2A RID: 6954 RVA: 0x00091A78 File Offset: 0x0008FC78
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x4FFC80", Offset = "0x4FE280", VA = "0x1804FFC80", Slot = "74")]
	protected override void ActionOnZombie(Zombie zombie, int damage)
	{
		ulong num6;
		do
		{
			float num = this.attributeFloat * 1.5f;
			zombie.SetPortaled(num);
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				uint num2;
				if (num2 == (uint)949)
				{
					int num3 = 0;
					int num4 = 0;
					zombie.SetCold(1f, num4, num3 != 0);
					Transform axis = zombie.axis;
					ParticleManager instance = ParticleManager.Instance;
					Transform axis2 = zombie.axis;
					Vector3 vector;
					float z = vector.z;
					PlantType thePlantType = this.thePlantType;
					uint num5;
					GameAPP.PlaySound((int)num5, 0.5f, 1f);
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x00091B48 File Offset: 0x0008FD48
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x5004A0", Offset = "0x4FEAA0", VA = "0x1805004A0", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[16];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
		return true;
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x00091BA8 File Offset: 0x0008FDA8
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x5008A0", Offset = "0x4FEEA0", VA = "0x1805008A0", Slot = "63")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		ulong num2;
		do
		{
			int num = 0;
			int theMouseRow = mouse.theMouseRow;
			List<Plant> list = Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow);
			bool flag;
			if (flag)
			{
				bool flag2 = base.CheckPlant(num);
				while (!flag2)
				{
				}
				if (!flag2 && !flag2)
				{
					while (!flag2)
					{
					}
				}
				this.targetPlant = num;
				bool flag3 = base.OnClicked(mouse);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00091C10 File Offset: 0x0008FE10
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x5002E0", Offset = "0x4FE8E0", VA = "0x1805002E0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num2;
		do
		{
			int num = 0;
			base.OnCreate((int)reason, num);
			Stack<UltimateLanternSplit.DamageLine> stack = this.lines;
			bool flag;
			if (flag)
			{
				UltimateLanternSplit.DamageLine damageLine;
				global::UnityEngine.Object.Destroy(damageLine.gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00091C5C File Offset: 0x0008FE5C
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x500130", Offset = "0x4FE730", VA = "0x180500130")]
	[ProButton]
	public void CreateLineAndUpdateIt()
	{
		UltimateLanternSplit.DamageLine damageLine = this.lines.Peek();
		if (damageLine.column != 0)
		{
			LineRenderer laserPrefab = this.laserPrefab;
			int column = damageLine.column;
			int num;
			UltimateLanternSplit.DamageLine damageLine2 = new UltimateLanternSplit.DamageLine(laserPrefab, num, this);
			num = column - 1;
			this.lines.Push(damageLine2);
			damageLine2.rightLine = damageLine;
			damageLine.leftLine = damageLine2;
			float explodeTimer = damageLine.explodeTimer;
			damageLine2.explodeTimer = explodeTimer;
		}
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00091D04 File Offset: 0x0008FF04
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x500690", Offset = "0x4FEC90", VA = "0x180500690", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		ulong num;
		do
		{
			base.OnFixedUpdate();
			Stack<UltimateLanternSplit.DamageLine> stack = this.lines;
			bool flag;
			if (flag)
			{
				float fixedDeltaTime = Time.fixedDeltaTime;
				UltimateLanternSplit.DamageLine damageLine;
				float damageTimer = damageLine.damageTimer;
				Plant plant = damageLine.plant;
				damageLine.damageTimer = damageTimer;
				damageLine.damageTimer = 0.2f;
				damageLine.SimpleDamage();
				float explodeTimer = damageLine.explodeTimer;
				Plant plant2 = damageLine.plant;
				damageLine.explodeTimer = explodeTimer;
				damageLine.explodeTimer = 20f;
				if (!Lawnf.TravelAdvanced((AdvBuff)((uint)12010)))
				{
					continue;
				}
				while (damageLine.rightLine == (ulong)0L)
				{
				}
				damageLine.Explode();
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x00091DD0 File Offset: 0x0008FFD0
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x500A40", Offset = "0x4FF040", VA = "0x180500A40")]
	public UltimateLanternSplit()
	{
		Stack<UltimateLanternSplit.DamageLine> stack = new Stack();
		this.lines = stack;
		base..ctor();
	}

	// Token: 0x04000EC7 RID: 3783
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000EC7")]
	private readonly Stack<UltimateLanternSplit.DamageLine> lines;

	// Token: 0x020005B6 RID: 1462
	[Token(Token = "0x20005B6")]
	private class DamageLine
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00091DF0 File Offset: 0x0008FFF0
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00091E04 File Offset: 0x00090004
		[Token(Token = "0x1700013E")]
		public float StartTimer
		{
			[Token(Token = "0x6001B31")]
			[Address(RVA = "0x4EF570", Offset = "0x4EDB70", VA = "0x1804EF570")]
			get
			{
				return this.explodeTimer;
			}
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x4EF580", Offset = "0x4EDB80", VA = "0x1804EF580")]
			set
			{
				this.explodeTimer = value;
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00091E18 File Offset: 0x00090018
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x4EF4A0", Offset = "0x4EDAA0", VA = "0x1804EF4A0")]
		public DamageLine(LineRenderer prefab, int column, Plant plant)
		{
			this.column = column;
			this.plant = plant;
			this.CreateLineObject(prefab);
			GameObject gameObject = Resources.Load<GameObject>("Plants/PeaShooter/LanternPea/UltimateLanternSplit/BlackHole");
			this.holePrefab = gameObject;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00091E54 File Offset: 0x00090054
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x4EEA00", Offset = "0x4ED000", VA = "0x1804EEA00")]
		private void CreateLineObject(LineRenderer prefab)
		{
			Transform transform = this.plant.board.transform;
			LineRenderer lineRenderer = global::UnityEngine.Object.Instantiate<LineRenderer>(prefab, transform);
			this.r = lineRenderer;
			GameObject gameObject = this.r.gameObject;
			this.gameObject = gameObject;
			this.gameObject.SetActive(true);
			GridSystem gridSystem = this.plant.board.gridSystem;
			int num = this.column;
			int num2 = 0;
			BoardGrid grid = gridSystem.GetGrid(num, num2);
			Vector2 position = grid.Position;
			Board board = this.plant.board;
			Plant plant = this.plant;
			GridSystem gridSystem2 = board.gridSystem;
			int rowNum = plant.board.rowNum;
			int num3 = this.column;
			BoardGrid grid2 = gridSystem2.GetGrid(num3, rowNum);
			Vector2 position2 = grid2.Position;
			LineRenderer lineRenderer2 = this.r;
			LineRenderer lineRenderer3 = this.r;
			SortingGroup component = this.r.GetComponent<SortingGroup>();
			int rowNum2 = this.plant.board.rowNum;
			string text = string.Format("particle{0}", component);
			component.sortingLayerName = text;
			Transform transform2 = this.r.transform;
			int num4 = 0;
			global::UnityEngine.Object.Destroy(transform2.GetChild(num4).gameObject);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00091F98 File Offset: 0x00090198
		[Token(Token = "0x1700013F")]
		private float Speed
		{
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x4EF550", Offset = "0x4EDB50", VA = "0x1804EF550")]
			get
			{
				return this.plant.attributeSpeed;
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00091FB8 File Offset: 0x000901B8
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x4EF0B0", Offset = "0x4ED6B0", VA = "0x1804EF0B0")]
		public void OnFixedUpdate(float deltaTime)
		{
			Plant plant = this.plant;
			float num = this.damageTimer;
			this.damageTimer = num;
			this.damageTimer = 0.2f;
			this.SimpleDamage();
			Plant plant2 = this.plant;
			float num2 = this.explodeTimer;
			this.explodeTimer = num2;
			this.explodeTimer = 20f;
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)12010)) && this.rightLine != (ulong)0L)
			{
				this.Explode();
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00092038 File Offset: 0x00090238
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x4EF170", Offset = "0x4ED770", VA = "0x1804EF170")]
		private void SimpleDamage()
		{
			LineRenderer lineRenderer = this.r;
			int num = 0;
			int num2 = 0;
			Vector3 vector;
			float z = vector.z;
			LineRenderer lineRenderer2 = this.r;
			LineRenderer lineRenderer3 = this.r;
			LayerMask zombieLayer = this.plant.zombieLayer;
			Vector3 vector2;
			float x = vector2.x;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				int num3;
				if (flag && num3 == this.column && Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.plant.thePlantType;
				}
				num++;
			}
			if (num2 != 0)
			{
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000920D4 File Offset: 0x000902D4
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x4EEDC0", Offset = "0x4ED3C0", VA = "0x1804EEDC0")]
		private void Explode()
		{
			LineRenderer lineRenderer = this.r;
			LineRenderer lineRenderer2 = this.rightLine.r;
			GameObject gameObject = this.holePrefab;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = Board.Instance.transform;
			GameObject gameObject2;
			BlackHole_split component = gameObject2.GetComponent<BlackHole_split>();
			Plant plant = this.plant;
			long num;
			component.theDamage = (int)num;
			PlantType thePlantType = this.plant.thePlantType;
			component.fromType = thePlantType;
			ParticleManager instance = ParticleManager.Instance;
			GameAPP.PlaySound((SoundType)((uint)95), 0.5f, 1f);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00092164 File Offset: 0x00090364
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x4EED70", Offset = "0x4ED370", VA = "0x1804EED70")]
		public void Die()
		{
			global::UnityEngine.Object.Destroy(this.gameObject);
		}

		// Token: 0x04000EC8 RID: 3784
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000EC8")]
		public int column;

		// Token: 0x04000EC9 RID: 3785
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000EC9")]
		public UltimateLanternSplit.DamageLine leftLine;

		// Token: 0x04000ECA RID: 3786
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000ECA")]
		public UltimateLanternSplit.DamageLine rightLine;

		// Token: 0x04000ECB RID: 3787
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000ECB")]
		private readonly Plant plant;

		// Token: 0x04000ECC RID: 3788
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000ECC")]
		private readonly GameObject holePrefab;

		// Token: 0x04000ECD RID: 3789
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000ECD")]
		private GameObject gameObject;

		// Token: 0x04000ECE RID: 3790
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000ECE")]
		private LineRenderer r;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		private const float damageInterval = 0.2f;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		private const float explodeInterval = 20f;

		// Token: 0x04000ED1 RID: 3793
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000ED1")]
		private float damageTimer;

		// Token: 0x04000ED2 RID: 3794
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000ED2")]
		private float explodeTimer;
	}
}
