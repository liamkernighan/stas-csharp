using System;
using System.Text;

namespace LearnCSharp
{
	public class Variables
	{
		private static int _count = 1;

		private static int _intMax = int.MaxValue;

		public int Склад = 5;

		#region region1

		public static void VariablesDeclarationAndLiterals()
		{
			var x = 1;
			int x2 = 1;

			var lng1 = 1L;
			long lng = 1L;

			long lng3 = 5;

			double dbl = 1.0;
			decimal dec = 25.0M;

			int hexLiteral = 0xFF;

			byte byte1 = 255;
			// byte byte2 = 256;

			// https://docs.microsoft.com/en-us/dotnet/api/system.int32.maxvalue?view=net-5.0
			var max = int.MaxValue;
			var maxLong = long.MaxValue;
			var minLong = long.MinValue;
			var minULong = ulong.MinValue;

			// https://stackoverflow.com/questions/5820721/c-sharp-short-long-int-literal-format

			System.Collections.ArrayList lst = new System.Collections.ArrayList();
			var lst2 = new System.Collections.ArrayList();

			string str = "Hello";
			var str2 = "Hello";
		}

		public static void VariableScopes()
		{
	
			//Console.WriteLine(_count);
			var count = 2; // перекрываем count

			{
				//var _count = 5;
				var count2 = 8;
			}


			//Console.WriteLine(count2);
		}

		public static void OverflowRules()
		{
			unchecked
			{
				var xx = uint.MinValue - 1;
			}

			// default checked
			// bool areEqual = (uint.MinValue - 1) == int.MaxValue;
			// bool areEqual2 = (int.MaxValue + 1) == int.MinValue;


			checked
			{
				var overflowed = _intMax + 1;
			}
		}

		public static void AlgebraicOperations()
		{
			var int1 = 1;
			long long1 = 1L;

			var long2 = 1;

			var var1 = int1 + long1;

			int1 = int1 + 1;
			int1 += 1;

			var int2 = int1++;
			var int3 = ++int1;


			var five1 = 5;
			var five2 = 5;

			var int4 = 5 + five1++;
			var int5 = 5 + ++five2;

			var int6 = 5 + five1++;
			var int7 = 5 + ++five2;

			var str = "Hello" + 5;

			bool isTrue = true || true;
		}

		public static void PrimitiveTypes_UpcastDownCast()
		{
			int x = 1;
			long lng = x;

			int int2 = (int)lng;

			double dbl = 2.1;

			int int3 = (int)dbl;
		}

		#endregion

		public int Add(int a, int b)
		{
			return a + b;
		}

		public void Test_NonStatic()
		{
			PrimitiveTypes_UpcastDownCast();

			// Обращение к текущему экземпляру
			Склад++;
			this.Склад++;
		}

		public void FillFromAnother(Variables another)
		{
			var Склад = 5;
			this.Склад = another.Склад;

			var number3 = new Variables();
			number3.FillFromAnother(this);
		}

		public static void Test_Static_NonStatic()
		{
			_count++;
			//_nonStaticCount++;

			Variables._count++; // Вот так можно вызвать из другого класса. Это как раз к вопросу об области видимости
		}

		public static void StringOperations()
		{
			string str1 = " Hello ";

			// Можешь загуглить, что такое культуры

			// .ToUpperInvariant(), .ToUpper(),
			string str2 = str1.Trim().ToUpperInvariant();

			var str3 = "Goodbye".ToLowerInvariant();

			var str4 = "Hello\nWorld";

			var str5 = "Hello\\n";
			var str6 = @"Hello" + @"\n";

			var str7 = @"Hello\n" + Environment.NewLine; // LF, CRLF

			var str8 = $@"Hello\n{Environment.NewLine}";


			var char1 = str1[0];



			var russian = str7;
			var char2 = russian[0];

			byte russianP = (byte)char2;

			bool areEqual1 = char1 == 'e';

			var empty = string.IsNullOrEmpty("");
			var empty2 = string.IsNullOrEmpty(" ");
			var empty3 = string.IsNullOrWhiteSpace(" \n");

			bool helloAreEqual = "hello" == "HELLO".ToLower();

			int isMore = "a".CompareTo("A");

			int isEqual = string.Compare("a", "A", ignoreCase: true);


		}

		public static void StringBuilder()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("A");
			stringBuilder.Append("B");

			string str = stringBuilder.ToString();
		}

		public static void Parse()
		{
			var x = int.Parse(5.ToString());

			//var y = int.Parse("A");

			var parsed = int.TryParse("A", out var result);

			//var bool1 = bool.TryParse("яйца true");

			5.ToString();

			var stringDate = DateTime.Today.AddDays(-1).AddMinutes(5).ToString("MMMM");

		}

		/// <summary>
		/// Comments Module
		/// </summary>
		/// <exception cref="InvalidOperationException" />
		/// <returns>void</returns>
		
		public static void Comments()
		{
			// Однострочный
			/*
			 * Многострочный
			 */

			throw new InvalidOperationException();
		}
	}
}
