using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E32 RID: 3634
	[Token(Token = "0x2000E32")]
	[Serializable]
	public class BLiveConfig
	{
		// Token: 0x06004AFF RID: 19199 RVA: 0x0017155C File Offset: 0x0016F75C
		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x8C9E50", Offset = "0x8C8450", VA = "0x1808C9E50")]
		public void AddScCount(string openId, long count)
		{
			Predicate<BLiveConfig.Record> predicate;
			int num = this.scTimes.FindIndex(predicate);
			if (num == -1)
			{
				BLiveConfig.Record record = new BLiveConfig.Record();
				string openId2 = openId;
				record.openId = openId2;
				record.restTime = count;
				List<BLiveConfig.Record> list = this.scTimes;
				int size = list._size;
				return;
			}
			BLiveConfig.Record record2 = this.scTimes[num];
			this.scTimes[num] = record2;
			throw new NullReferenceException();
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x001715E0 File Offset: 0x0016F7E0
		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x8CA070", Offset = "0x8C8670", VA = "0x1808CA070")]
		public bool HasScCount(string openId)
		{
			new BLiveConfig.<>c__DisplayClass8_0().openId = openId;
			Predicate<BLiveConfig.Record> predicate;
			int num = this.scTimes.FindIndex(predicate);
			if (num != -1)
			{
				BLiveConfig.Record record = this.scTimes[num];
				return true;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x00171620 File Offset: 0x0016F820
		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x8CA190", Offset = "0x8C8790", VA = "0x1808CA190")]
		public void UseScCount(string openId, int count)
		{
			new BLiveConfig.<>c__DisplayClass9_0().openId = openId;
			Predicate<BLiveConfig.Record> predicate;
			int num = this.scTimes.FindIndex(predicate);
			if (num != -1)
			{
				BLiveConfig.Record record = this.scTimes[num];
				this.scTimes[num] = record;
			}
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0017166C File Offset: 0x0016F86C
		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x8CA2F0", Offset = "0x8C88F0", VA = "0x1808CA2F0")]
		public BLiveConfig()
		{
			List<BLiveConfig.Record> list = new List();
			this.scTimes = list;
			base..ctor();
		}

		// Token: 0x04003523 RID: 13603
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003523")]
		public SpawnMode spawnMode;

		// Token: 0x04003524 RID: 13604
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003524")]
		public int maxZombieCount = (int)((ulong)300L);

		// Token: 0x04003525 RID: 13605
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003525")]
		public int likePerSpawn = (int)((ulong)100L);

		// Token: 0x04003526 RID: 13606
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4003526")]
		public int damMaxPerSpawn = (int)((ulong)3L);

		// Token: 0x04003527 RID: 13607
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003527")]
		public int baseBulletDamage = (int)((ulong)300L);

		// Token: 0x04003528 RID: 13608
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003528")]
		public List<BLiveConfig.Record> scTimes;

		// Token: 0x04003529 RID: 13609
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003529")]
		public bool scMode;

		// Token: 0x02000E33 RID: 3635
		[Token(Token = "0x2000E33")]
		[Serializable]
		public class Record
		{
			// Token: 0x06004B03 RID: 19203 RVA: 0x001716BC File Offset: 0x0016F8BC
			[Token(Token = "0x6004B03")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public Record()
			{
			}

			// Token: 0x0400352A RID: 13610
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400352A")]
			public string openId;

			// Token: 0x0400352B RID: 13611
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400352B")]
			public long restTime;
		}
	}
}
