using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GameTest_1_3_2()
        {
            int myColor = 7;
            int enemyColor = 7;
            int myChip = 0;
            int enemyChip = 0;
            int expected = 2;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 1, 3);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GameTest_2_2_2()
        {
            int myColor = 7;
            int enemyColor = 7;
            int myChip = 0;
            int enemyChip = 0;
            int expected = 2;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 2, 2);
            Assert.AreEqual(expected, actual);

        }
        //проверка если фишек меньше очков
        [TestMethod()]
        public void GameTest_2_2()
        {
            int myColor = 1;
            int enemyColor = 7;
            int myChip = 0;
            int enemyChip = 0;
            int expected = 1;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 2, 4);
            Assert.AreEqual(expected, actual);

        }
        //проверка на вражеские фишки
        [TestMethod()]
        public void GameTest_2()
        {
            int myColor = 1;
            int enemyColor = 1;
            int myChip = 0;
            int enemyChip = 0;
            int expected = 1;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 2, 2);
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// если фишек нет
        /// </summary>
        [TestMethod()]

        public void GameTest_5()
        {
            int myColor = 0;
            int enemyColor = 1;
            int myChip = 5;
            int enemyChip = 0;
            int expected = 5;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 2, 3);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// если вражеских фишек нету
        /// </summary>
        [TestMethod()]
        public void GameTest_6()
        {
            int myColor = 1;
            int enemyColor = 0;
            int myChip = 0;
            int enemyChip = 0;
            int expected = 0;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 2, 2);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GameTest_8bespolezny()
        {
            int myColor = 7;
            int enemyColor = 0;
            int myChip = 0;
            int enemyChip = 0;
            int expected = 6;
            Logic logic = new Logic();
            var actual = logic.Game(myColor, enemyColor, myChip, enemyChip, 1, 7);
            Assert.AreEqual(expected, actual);
        }

       
    }
}