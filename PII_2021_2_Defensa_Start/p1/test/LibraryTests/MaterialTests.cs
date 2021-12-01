using NUnit.Framework;
using System;

namespace Ucu.Poo.Defense.Tests
{
    public class MaterialTests
    {
        MaterialType dangerousType;
        MaterialType nonDangerousType;

        [SetUp]
        public void Setup()
        {
            this.nonDangerousType = new MaterialType("Non dangerous type", false);
            this.dangerousType = new MaterialType("Dangerous type", true);
        }

        [Test]
        public void TestCreateNonDangerousMaterial()
        {
            Material material = new("Non dangerous material", nonDangerousType, false);
            Assert.That(material.IsDangerous, Is.False);
        }

        [Test]
        public void TestCreateDangerousMaterial()
        {
            Material material = new("Dangerous material", dangerousType, true);

            Assert.That(material.IsDangerous, Is.True);

        }
    }
}