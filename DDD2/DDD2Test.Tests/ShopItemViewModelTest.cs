using DDD2.Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DDD2Test.Tests
{
    [TestClass]
    public class ShopItemViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var itemMock = new Mock<IItemRepository>();
        }
    }
}
