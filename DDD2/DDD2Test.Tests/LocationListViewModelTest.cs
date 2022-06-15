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
    public class LocationListViewModelTest
    {
        [TestMethod]
        public void 場所一覧画面シナリオ()
        {
            var entities = new List<LocationEntity>();
            entities.Add(
                new LocationEntity(1, "東京")
                );
            entities.Add(
                new LocationEntity(2, "大阪")
            );
            entities.Add(
                new LocationEntity(3, "名古屋")
            );

            var mock = new Mock<ILocationRepository>();
            mock.Setup(x => x.GetData()).Returns(entities);

            var viewModel = new LocationListViewModel(mock.Object);
            viewModel.Locations.Count.Is(3);
            viewModel.Locations[0].LocationId.Is("01");
            viewModel.Locations[0].LocationName.Is("東京");
            viewModel.Locations[1].LocationId.Is("02");
            viewModel.Locations[1].LocationName.Is("大阪");
            viewModel.Locations[2].LocationId.Is("03");
            viewModel.Locations[2].LocationName.Is("名古屋");
        }
    }
}
