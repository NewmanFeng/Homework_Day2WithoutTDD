using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookShop.Tests
{
    [TestClass()]
    public class BookShopTests
    {
        [TestMethod()]
        public void GetBillPriceTest1()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target=new BookShop();
            var expected = 100.0m;

            Assert.AreEqual(expected,target.GetBillPrice(books));
        }
        [TestMethod()]
        public void GetBillPriceTest2()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target = new BookShop();
            var expected = 190.0m;

            Assert.AreEqual(expected, target.GetBillPrice(books));
        }
        [TestMethod()]
        public void GetBillPriceTest3()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target = new BookShop();
            var expected = 270.0m;

            Assert.AreEqual(expected, target.GetBillPrice(books));
        }
        [TestMethod()]
        public void GetBillPriceTest4()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target = new BookShop();
            var expected = 320.0m;

            Assert.AreEqual(expected, target.GetBillPrice(books));
        }
        [TestMethod()]
        public void GetBillPriceTest5()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target = new BookShop();
            var expected = 375.0m;

            Assert.AreEqual(expected, target.GetBillPrice(books));
        }
        [TestMethod()]
        public void GetBillPriceTest6()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 2,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target = new BookShop();
            var expected = 370.0m;

            Assert.AreEqual(expected, target.GetBillPrice(books));
        }
        [TestMethod()]
        public void GetBillPriceTest7()
        {
            var books = new List<Book>()
            {
                new Book() {Count = 1,Name = "HollyPoter",SerialNo =1 ,SinglePrice = 100.0m},
                new Book() {Count = 2,Name = "HollyPoter",SerialNo =2 ,SinglePrice = 100.0m},
                new Book() {Count = 2,Name = "HollyPoter",SerialNo =3 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =4 ,SinglePrice = 100.0m},
                new Book() {Count = 0,Name = "HollyPoter",SerialNo =5 ,SinglePrice = 100.0m},
            };
            var target = new BookShop();
            var expected = 460.0m;

            Assert.AreEqual(expected, target.GetBillPrice(books));
        }
    }
}