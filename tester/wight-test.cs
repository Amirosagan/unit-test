using Microsoft.VisualStudio.TestTools.UnitTesting;
using totest;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Moq;
using FakeItEasy;

namespace tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Weghit_sexM_hegiht180_return__72_5()
        {
            // Arrange 
            Wight sut = new Wight
            {
                heght = 180,
                sex = 'm'
            };

            // Act

            var actule = sut.getSutibleWegith();
            double expected = 72.5;

            // Assert

            actule.Should().Be(expected);

            

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Weghit_sexW_hegiht170_return__0()
        {
            Wight sut = new Wight 
            {
                heght = 170,
                sex = 'W'
            };

            sut.getSutibleWegith().Should().Be(0);

        }

        [TestMethod]
        [Owner ("Amir")]
        [Description ("to test from out database")]
        public void MyTestMethod()
        {
            Wight tests = new Wight(new Fakerepo());

            double[] results = { 80, 50, 55, 66.5 };

            tests.getweghtsfromdatasourse().Should().BeEquivalentTo(results);

        }

        [TestMethod]
        [Description ("test with moq")]
        public void test_with_fake_repo_moq()
        {
            List<Wight> wights = new List<Wight>() {
                new Wight { heght = 190,sex = 'm' },
                new Wight { heght = 150,sex = 'g' },
                new Wight { heght = 160,sex = 'g' }
            };
            Mock<IDatarepo> repo = new Mock<IDatarepo>();

            repo.Setup(w => w.GetWights()).Returns(wights);

            Wight calc = new Wight(repo.Object);

            var acturle = calc.getweghtsfromdatasourse();

            double[] ex = { 80, 50, 55 };

            acturle.Should().BeEquivalentTo(ex);

        }
        [TestMethod]
        [Description ("test with fakeIteasy")]
        public void test_with_fake_repo_fake_it_easy()
        {
            List<Wight> wights = new List<Wight>()
            {
                new Wight { heght = 190,sex = 'm' },
                new Wight { heght = 150,sex = 'g' }
            };


            IDatarepo repo = A.Fake<IDatarepo>();

            A.CallTo(() => repo.GetWights()).Returns(wights);

            Wight calc = new Wight(repo);

            var act = calc.getweghtsfromdatasourse();

            double[] ex = { 80, 50 };


            act.Should().BeEquivalentTo(ex);



        }
        [DataTestMethod]
        [DataRow ( 190,'m', 80)]
        [DataRow ( 150, 'g', 50)]
        public void test_with_driven_terst(double heghit, char sex, double ex)
        {
            Wight wight = new Wight()
            {
                heght = heghit,
                sex = sex
            };

            wight.getSutibleWegith().Should().Be(ex);

        }
    }
}