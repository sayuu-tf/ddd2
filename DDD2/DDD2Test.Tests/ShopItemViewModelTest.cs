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
    public class ShopItemViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var items1 = new List<ItemEntity>();
            items1.Add(new ItemEntity("定規", 500, 1));
            items1.Add(new ItemEntity("えんぴつ", 100, 1));
            items1.Add(new ItemEntity("ペンケース", 1200, 1));

            var items2 = new List<ItemEntity>();
            items2.Add(new ItemEntity("コーラ", 120, 2));
            items2.Add(new ItemEntity("ワイン", 980, 2));
            items2.Add(new ItemEntity("サンドイッチ", 380, 2));

            var itemMock = new Mock<IItemRepository>();
            itemMock.Setup(x => x.GetItem(1)).Returns(items1);
            itemMock.Setup(x => x.GetItem(2)).Returns(items2);

            var viewModel = new ShopItemViewModel(itemMock.Object);

            //初期値は空
            viewModel.SelectedShopId.Is("");

            //1を入れてボタンを押す
            viewModel.SelectedShopId = "1";
            viewModel.Search();

            //結果表示
            viewModel.SelectedShopId.Is("1");
        }
    }
}
