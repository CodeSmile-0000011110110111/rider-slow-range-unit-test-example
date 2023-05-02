// Copyright (C) 2021-2023 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using ClassLibrary1;
using NUnit.Framework;

namespace TestProject1
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test1([Range(0, 1000, 1)] int value)
		{
			var c = new Class1();

			c.Value = value;

			Assert.That(c.GetValue(), Is.EqualTo(value));
		}
	}
}
