using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pawnshop;

namespace PawnshopTests
{
    [TestClass]
    public class PawnshopTests
    {
        [TestMethod]
        public void Login_ExistsUser_ReturnedTrue() // Проверка авторизации. Ввод существующего пользователя
        {
            //arrange
            Pawnshop.Helpers.Authorization authorizationHelper = new Pawnshop.Helpers.Authorization();
            string login = "gatunov";
            string password = "gatunov";
            bool expected = true;
            //act
            bool actual = authorizationHelper.Login(login, password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login_NotExistsUser_ReturnedFalse() // Проверка авторизации. Ввод не существующего пользователя
        {
            //arrange
            Pawnshop.Helpers.Authorization authorizationHelper  = new Pawnshop.Helpers.Authorization();
            string login = "User";
            string password = "User";
            bool expected = false;
            //act
            bool actual = authorizationHelper.Login(login, password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CharacterCheck_NonExistsRussianLetters_ReturnedFalse() // Проверка валидации на наличие русских букв
        {
            //arrange
           Pawnshop.Helpers.Validator validationHelper = new Pawnshop.Helpers.Validator();
            string arg = "Привет";
            bool expected = false;
            //act
            bool actual = validationHelper.CharacterCheck(arg);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CharacterCheck_NonExistsRussianLetters_ReturnedTrue()
        {
            //arrange
            Pawnshop.Helpers.Validator validationHelper = new Pawnshop.Helpers.Validator();
            string arg = "Hello";
            bool expected = true;
            //act
            bool actual = validationHelper.CharacterCheck(arg);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
