using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace ClockClassLibrary.Tests
{
    public class ClockAdapterTests
    {
        private const int MINUTE_ANGLE = 6;

        private const int HOUR_ANGLE = 30;

        private const double HOUR_OFFSET = 0.5;

        private const double RADIAN = Math.PI / 180;

        [Fact]
        public void GetSsHandPosition_WhenDigitalClockIsValid_ShouldReturnCorrectValues()
        {
            // Arrange
            DigitalClock digitalClock = new DigitalClock();

            // Act
            ClockAdapter clockAdapter = new ClockAdapter(digitalClock);

            // Assert
            clockAdapter.GetSsHandPosition()
                .Should()
                .NotBeEmpty()
                .And.HaveCount(2)
                .And.ContainItemsAssignableTo<double>();

            clockAdapter.GetSsHandPosition()[0]
                .Should()
                .BeApproximately(Math.Sin(RADIAN * digitalClock.Ss * MINUTE_ANGLE), 0.01f);

            clockAdapter.GetSsHandPosition()[1]
                .Should()
                .BeApproximately(Math.Cos(RADIAN * digitalClock.Ss * MINUTE_ANGLE), 0.01f);
        }

        [Fact]
        public void GetMmHandPosition_WhenDigitalClockIsValid_ShouldReturnCorrectValues()
        {
            // Arrange
            DigitalClock digitalClock = new DigitalClock();

            // Act
            ClockAdapter clockAdapter = new ClockAdapter(digitalClock);

            // Assert
            clockAdapter.GetMmHandPosition()
                .Should()
                .NotBeEmpty()
                .And.HaveCount(2)
                .And.ContainItemsAssignableTo<double>();

            clockAdapter.GetMmHandPosition()[0]
                .Should()
                .BeApproximately(Math.Sin(RADIAN * digitalClock.Mm * MINUTE_ANGLE), 0.01f);

            clockAdapter.GetMmHandPosition()[1]
                .Should()
                .BeApproximately(Math.Cos(RADIAN * digitalClock.Mm * MINUTE_ANGLE), 0.01f);
        }

        [Fact]
        public void GetHhHandPosition_WhenDigitalClockIsValid_ShouldReturnCorrectValues()
        {
            // Arrange
            DigitalClock digitalClock = new DigitalClock();

            // Act
            ClockAdapter clockAdapter = new ClockAdapter(digitalClock);

            // Assert
            clockAdapter.GetHhHandPosition()
                .Should()
                .NotBeEmpty()
                .And.HaveCount(2)
                .And.ContainItemsAssignableTo<double>();

            clockAdapter.GetHhHandPosition()[0]
                .Should()
                .BeApproximately(Math.Sin(RADIAN * (int)(digitalClock.Hh * HOUR_ANGLE + digitalClock.Mm * HOUR_OFFSET)), 0.01f);

            clockAdapter.GetHhHandPosition()[1]
                .Should()
                .BeApproximately(Math.Cos(RADIAN * (int)(digitalClock.Hh * HOUR_ANGLE + digitalClock.Mm * HOUR_OFFSET)), 0.01f);
        }

        [Fact]
        public void CreateAdapter_WhenDigitalClockIsValid_ShouldNotThrowArgumentNullException()
        {
            // Arrange
            DigitalClock digitalClock = new DigitalClock();

            // Act
            Action action = () => new ClockAdapter(digitalClock);

            // Assert
            action
                .Should()
                .NotThrow<ArgumentNullException>();
        }

        [Fact]
        public void CreatAdapter_WhenDigitalClockIsNull_ShouldThrowArgumentNullException()
        {
            // Arrange - Act
            Action action = () => new ClockAdapter(null);

            // Assert
            action
                .Should()
                .Throw<ArgumentNullException>()
                .WithMessage("*digitalClock*");
        }
    }
}
