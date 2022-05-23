using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using DDD2.WinForm.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DDD2Test.Tests
{
    [TestClass]
    public class ShopListViewModelTest
    {
        [TestMethod]
        public void お店一覧画面シナリオ()
        {
            var entities = new List<ShopEntity>();
            entities.Add(
                new ShopEntity("ルタオ", "小樽", 1)             
                );
            entities.Add(
                new ShopEntity("六花亭", "帯広", 2)
            );

            var shopMock = new Mock<IShopRepository>();
            shopMock.Setup(x => x.GetData()).Returns(entities);

            var viewModel = new ShopListViewModel(shopMock.Object);
            viewModel.Shops.Count.Is(2);
            
        }
    }
}
