using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E3A RID: 3642
	[Token(Token = "0x2000E3A")]
	public abstract class EndianBitConverter
	{
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06004B13 RID: 19219 RVA: 0x00171930 File Offset: 0x0016FB30
		[Token(Token = "0x1700096E")]
		public static EndianBitConverter LittleEndian
		{
			[Token(Token = "0x6004B13")]
			[Address(RVA = "0x8CC270", Offset = "0x8CA870", VA = "0x1808CC270")]
			get;
		} = new LittleEndianBitConverter
		{
			<IsLittleEndian>k__BackingField = true
		};

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x00171944 File Offset: 0x0016FB44
		[Token(Token = "0x1700096F")]
		public static EndianBitConverter BigEndian
		{
			[Token(Token = "0x6004B14")]
			[Address(RVA = "0x8CC220", Offset = "0x8CA820", VA = "0x1808CC220")]
			get;
		} = new BigEndianBitConverter();

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06004B15 RID: 19221
		[Token(Token = "0x17000970")]
		public abstract bool IsLittleEndian
		{
			[Token(Token = "0x6004B15")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00171958 File Offset: 0x0016FB58
		[Token(Token = "0x6004B16")]
		[Address(RVA = "0x8CBE90", Offset = "0x8CA490", VA = "0x1808CBE90")]
		public byte[] GetBytes(bool value)
		{
			return new byte[] { value ? 1 : 0 };
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x0017197C File Offset: 0x0016FB7C
		[Token(Token = "0x6004B17")]
		[Address(RVA = "0x8CBEF0", Offset = "0x8CA4F0", VA = "0x1808CBEF0")]
		public byte[] GetBytes(char value)
		{
			return null;
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x0017198C File Offset: 0x0016FB8C
		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x8CBF10", Offset = "0x8CA510", VA = "0x1808CBF10")]
		public byte[] GetBytes(double value)
		{
			return null;
		}

		// Token: 0x06004B19 RID: 19225
		[Token(Token = "0x6004B19")]
		[Address(Slot = "5")]
		public abstract byte[] GetBytes(short value);

		// Token: 0x06004B1A RID: 19226
		[Token(Token = "0x6004B1A")]
		[Address(Slot = "6")]
		public abstract byte[] GetBytes(int value);

		// Token: 0x06004B1B RID: 19227
		[Token(Token = "0x6004B1B")]
		[Address(Slot = "7")]
		public abstract byte[] GetBytes(long value);

		// Token: 0x06004B1C RID: 19228 RVA: 0x0017199C File Offset: 0x0016FB9C
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x8CBF50", Offset = "0x8CA550", VA = "0x1808CBF50")]
		public byte[] GetBytes(float value)
		{
			return null;
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x001719AC File Offset: 0x0016FBAC
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x8CBEF0", Offset = "0x8CA4F0", VA = "0x1808CBEF0")]
		public byte[] GetBytes(ushort value)
		{
			return null;
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x001719BC File Offset: 0x0016FBBC
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x8CBF30", Offset = "0x8CA530", VA = "0x1808CBF30")]
		public byte[] GetBytes(uint value)
		{
			return null;
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x001719CC File Offset: 0x0016FBCC
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x8CBE70", Offset = "0x8CA470", VA = "0x1808CBE70")]
		public byte[] GetBytes(ulong value)
		{
			return null;
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x001719DC File Offset: 0x0016FBDC
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x8CBF70", Offset = "0x8CA570", VA = "0x1808CBF70")]
		public bool ToBoolean(byte[] value, int startIndex)
		{
			if (value != 0)
			{
				int length = value.Length;
				return false;
			}
			return false;
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x001719FC File Offset: 0x0016FBFC
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x8CC040", Offset = "0x8CA640", VA = "0x1808CC040")]
		public char ToChar(byte[] value, int startIndex)
		{
			return '\0';
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00171A0C File Offset: 0x0016FC0C
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x8CC060", Offset = "0x8CA660", VA = "0x1808CC060")]
		public double ToDouble(byte[] value, int startIndex)
		{
			long num = this.ToInt64(value, startIndex);
			return 0.0;
		}

		// Token: 0x06004B23 RID: 19235
		[Token(Token = "0x6004B23")]
		[Address(Slot = "8")]
		public abstract short ToInt16(byte[] value, int startIndex);

		// Token: 0x06004B24 RID: 19236
		[Token(Token = "0x6004B24")]
		[Address(Slot = "9")]
		public abstract int ToInt32(byte[] value, int startIndex);

		// Token: 0x06004B25 RID: 19237
		[Token(Token = "0x6004B25")]
		[Address(Slot = "10")]
		public abstract long ToInt64(byte[] value, int startIndex);

		// Token: 0x06004B26 RID: 19238 RVA: 0x00171A2C File Offset: 0x0016FC2C
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x8CC090", Offset = "0x8CA690", VA = "0x1808CC090")]
		public float ToSingle(byte[] value, int startIndex)
		{
			int num = this.ToInt32(value, startIndex);
			return 0f;
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00171A48 File Offset: 0x0016FC48
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x8CC040", Offset = "0x8CA640", VA = "0x1808CC040")]
		public ushort ToUInt16(byte[] value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00171A58 File Offset: 0x0016FC58
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x8CC0B0", Offset = "0x8CA6B0", VA = "0x1808CC0B0")]
		public uint ToUInt32(byte[] value, int startIndex)
		{
			return 0U;
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00171A68 File Offset: 0x0016FC68
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x8CC0D0", Offset = "0x8CA6D0", VA = "0x1808CC0D0")]
		public ulong ToUInt64(byte[] value, int startIndex)
		{
			return 0UL;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00171A78 File Offset: 0x0016FC78
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x8CBDB0", Offset = "0x8CA3B0", VA = "0x1808CBDB0")]
		internal void CheckArguments(byte[] value, int startIndex, int byteLength)
		{
			if (value != 0)
			{
				int num = value.Length;
				num -= byteLength;
				return;
			}
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00171A98 File Offset: 0x0016FC98
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected EndianBitConverter()
		{
		}
	}
}
