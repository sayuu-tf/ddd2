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
                new ShopEntity(1, "ルタオ", 1, "小樽", 300)             
                );
            entities.Add(
                new ShopEntity(2, "六花亭", 2, "帯広", 400)
            );

            var shopMock = new Mock<IShopRepository>();
            shopMock.Setup(x => x.GetData()).Returns(entities);

            var viewModel = new ShopListViewModel(shopMock.Object);
            viewModel.Shops.Count.Is(2);
            viewModel.Shops[0].ShopId.Is("0001");
            viewModel.Shops[0].ShopName.Is("ルタオ");
            viewModel.Shops[0].LocationId.Is("01");
            viewModel.Shops[0].LocationName.Is("小樽");
            viewModel.Shops[0].Profit.Is("300");

            viewModel.Shops[1].ShopId.Is("0002");
            viewModel.Shops[1].ShopName.Is("六花亭");
            viewModel.Shops[1].LocationId.Is("02");
            viewModel.Shops[1].LocationName.Is("帯広");
            viewModel.Shops[1].Profit.Is("400");

        }
    }
}
